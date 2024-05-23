#include "pch.h"
#ifdef _WIN32
#include <windows.h>
#endif
#include <cstdlib>
#include <locale>
#include <cctype>

#include <iostream>
using std::cout;
using std::cerr;
using std::endl;

#include <string>
using std::string;

#include <stdexcept>
using std::runtime_error;

#include <exception>
using std::exception;

#include "cryptopp/pem.h"

#include <cryptopp/queue.h>
using CryptoPP::ByteQueue;

#include <cryptopp/files.h>
using CryptoPP::FileSource;
using CryptoPP::FileSink;

#include "cryptopp/integer.h"// lam viev voi so lon
using CryptoPP::Integer;

#include "cryptopp/rsa.h"
using CryptoPP::RSA;
using CryptoPP::InvertibleRSAFunction;
using CryptoPP::RSAES_OAEP_SHA_Encryptor;
using CryptoPP::RSAES_OAEP_SHA_Decryptor;

#include "cryptopp/sha.h"
using CryptoPP::SHA1;

#include "cryptopp/filters.h"
using CryptoPP::StringSink;
using CryptoPP::StringSource;
using CryptoPP::PK_EncryptorFilter;
using CryptoPP::PK_DecryptorFilter;

#include "cryptopp/hex.h"
using CryptoPP::HexEncoder;
using CryptoPP::HexDecoder;

#include "cryptopp/base64.h"
using CryptoPP::Base64Encoder;
using CryptoPP::Base64Decoder;

#include <cryptopp/cryptlib.h>
using CryptoPP::PrivateKey;
using CryptoPP::PublicKey;
using CryptoPP::BufferedTransformation;
using CryptoPP::Exception;
using CryptoPP::DecodingResult;

#include "cryptopp/osrng.h"
using CryptoPP::AutoSeededRandomPool;

#include "cryptopp/secblock.h"
using CryptoPP::SecByteBlock;

//save rsa keys (der-binary)
void Save(const string& filename, const BufferedTransformation& bt);
void SavePrivateKey(const string& filename, const PrivateKey& key);
void SavePublicKey(const string& filename, const PublicKey& key);

//load rsa keys (der-binary)
void Load(const string& filename, BufferedTransformation& bt);
void LoadPrivateKey(const string& filename, PrivateKey& key);
void LoadPublicKey(const string& filename, PublicKey& key);

#ifndef DLL_EXPORT
#ifdef _WIN32
#define DLL_EXPORT __declspec(dllexport)
#else
#define DLL_EXPORT
#endif
#endif

// Declare functions with extern "C" to prevent name mangling in C++
extern "C" {
	DLL_EXPORT double GenerateAndSaveRSAKeys(int keySize, const char* format, const char* privateKeyFile, const char* publicKeyFile);
	DLL_EXPORT double RSAencrypt(const char* format, const char* publicKeyFile, const char* PlaintextFile, const char* CiphertFile);
	DLL_EXPORT double RSAdecrypt(const char* format, const char* privateKeyFile, const char* CiphertextFile, const char* PlaintextFile);
} 

double GenerateAndSaveRSAKeys(int keySize, const char* format, const char* privateKeyFile, const char* publicKeyFile) 
{
	//conver command-line chars to string
	string strFormat(format);
	string strPrivateKeyFile(privateKeyFile);
	string strPublicKeyFile(publicKeyFile);
	AutoSeededRandomPool rnd;

	RSA::PrivateKey rsaPrivate;
	
	//generate keys
	auto start = std::chrono::high_resolution_clock::now();
	rsaPrivate.GenerateRandomWithKeySize(rnd, keySize);
	RSA::PublicKey rsaPublic(rsaPrivate);
	//save keys
	if (strFormat == "BER")
	{
		SavePrivateKey(strPrivateKeyFile, rsaPrivate);
		SavePublicKey(strPublicKeyFile, rsaPublic);
        FileSink pubkey(publicKeyFile,true);
        CryptoPP::PEM_Save(pubkey,rsaPublic);
	}
	else if (strFormat == "PEM")
	{
		FileSink prikey(privateKeyFile,true);
        CryptoPP::PEM_Save(prikey,rsaPrivate);
		FileSink pubkey(publicKeyFile,true);
        CryptoPP::PEM_Save(pubkey,rsaPublic);
    }
	else
	{
		cerr <<"Unsupported. Please choose format BER or PEM";
		exit(1);
	}
	auto end = std::chrono::high_resolution_clock::now();
	auto duration = std::chrono::duration_cast<std::chrono::milliseconds>(end - start).count();
	double averageTime = static_cast<double>(duration);
	return averageTime;

}
double RSAencrypt( const char* format, const char* publicKeyFile, const char* PlaintextFile, const char* CipherFile ) 
{

    string strFormat(format);
    string strPublicKeyFile(publicKeyFile);
    RSA::PublicKey publicKey;
	auto start = std::chrono::high_resolution_clock::now();
    //Load keys
    if (strFormat == "BER")
	{
		LoadPublicKey(strPublicKeyFile, publicKey);
	}
	else if (strFormat == "PEM")
	{
		FileSource pubkey(publicKeyFile,true);
        CryptoPP::PEM_Load(pubkey,publicKey);
	}
	else
	{
		cerr <<"Unsupported. Please choose format 'BER' or 'PEM'";
		exit(1);
	}
   
    //Load plaintext
    string plain, cipher;
    AutoSeededRandomPool rnd;
    FileSource(PlaintextFile, true, new StringSink(plain),false);
    //Run Encryption and save file
    //Encrypt with OAEF padding, SHA1
    RSAES_OAEP_SHA_Encryptor e( publicKey );
    //Run encrypt function and save to file
    StringSource( plain, true,
        new PK_EncryptorFilter( rnd, e,
            new FileSink( CipherFile,true) //Binary cipher
        ) // PK_EncryptorFilter
        ); // StringSource

    //Save Cipher
	auto end = std::chrono::high_resolution_clock::now();
	auto duration = std::chrono::duration_cast<std::chrono::milliseconds>(end - start).count();
	double averageTime = static_cast<double>(duration);
    return averageTime;
}
double RSAdecrypt( const char* format, const char* secretKeyFile, const char* CipherFile, const char* PlaintextFile) 
{
    string strFormat(format);
    string strSecretKeyFile(secretKeyFile);
    RSA::PrivateKey privateKey;
	auto start = std::chrono::high_resolution_clock::now();
    //Load keys
    if (strFormat == "BER")
	{
		LoadPrivateKey(strSecretKeyFile, privateKey);
	}
	else if (strFormat == "PEM")
	{
		FileSource prikey(secretKeyFile,true);
        CryptoPP::PEM_Load(prikey,privateKey);
	}
	else
	{
		cerr <<"Unsupported. Please choose format 'BER' or 'PEM'";
		exit(1);
	}
   
    string cipher,plaintext;
    AutoSeededRandomPool rnd;
    FileSource(CipherFile, true, new StringSink(cipher));
    RSAES_OAEP_SHA_Decryptor d( privateKey );
   
    StringSource( cipher, true,
        new PK_DecryptorFilter( rnd, d,
            new FileSink( PlaintextFile,false) 
        ) 
        ); 
    StringSource( cipher, true,
        new PK_DecryptorFilter( rnd, d,
            new StringSink( plaintext) 
        ) 
        ); 
    auto end = std::chrono::high_resolution_clock::now();
	auto duration = std::chrono::duration_cast<std::chrono::milliseconds>(end - start).count();
	double averageTime = static_cast<double>(duration);
    return averageTime;
    

}
//Def functions
void SavePrivateKey(const string& filename, const PrivateKey& key)
{
	ByteQueue queue;
	key.Save(queue);

	Save(filename, queue);
}

void SavePublicKey(const string& filename, const PublicKey& key)
{
	ByteQueue queue;
	key.Save(queue);

	Save(filename, queue);
}

void Save(const string& filename, const BufferedTransformation& bt)
{
	FileSink file(filename.c_str());

	bt.CopyTo(file);
	file.MessageEnd();
}

void LoadPrivateKey(const string& filename, PrivateKey& key)
{
	ByteQueue queue;

	Load(filename, queue);
	key.Load(queue);	
}

void LoadPublicKey(const string& filename, PublicKey& key)
{
	ByteQueue queue;

	Load(filename, queue);
	key.Load(queue);	
}

void Load(const string& filename, BufferedTransformation& bt)
{
	FileSource file(filename.c_str(), true /*pumpAll*/);

	file.TransferTo(bt);
	bt.MessageEnd();
}


