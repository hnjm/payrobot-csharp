# Payrobot C# SDK

# Introduction
Accept, store, send or forward Bitcoin, Litecoin and Bitcoin Cash for your website or app and protect your privacy.

Supported crytocurrencies:
  * BTC Bitcoin
  * LTC Litecoin
  * BCH Bitcoin Cash


## Benefits

  * **Anonymous** No personal details are required and transactions are mixed among all payments. You can forward your payments so as soon payrobot.io receives it forwards it to another address under your control.
  
  * **No Registration** No registration, sign-up, application or form required to use payrobot.io
  
  * **Easy Integration** Integrate your web / app through our simple RESTful API, you can accept payments with just one line of code!
  
  * **Instant Payment Notification** Our servers notify your web / app the status of your payments. No polling, daemons or cronjobs required on your side!
  
  * **Secure** Payrobot.io works with SSL and bank-level security protocols. Your transactions are safe!


## Features
**Payment Forward**
Generate one-time addresses to recieve payments. Payrobot will notify your web /app through callbacks (webhooks) the status of the payment. As soon as it's confirmed the payment is forwarded to your desired address.

**Wallet**
Receive, send payments and store your coins in a secure, private and anonymous wallet. All events are notified to your web / app through callbacks (webhooks). You can generate wallets with just one line of code without registration or further information

## Fees
**Only 0.90% per inbound transaction** (receive payments), NO HIDDEN FEES. All outbound transactions (send funds) are totally free.

Minimum fees applies, therefore the largest amount is going to be considered as fee either: `(inboundAmount*feePct)` or `the minimum fee`

**Inbound Fees (Receive payments)**

  - `Bitcoin` 0.90% *(Minimum fee 0.00005 BTC)*
  - `Litecoin` 0.90% *(Minimum fee 0.0005 LTC)*
  - `Bitcoin Cash` 0.90% *(Minimum fee 0.0005 BCH)*
  

**Outbound Fees (Send funds)**

  - `Bitcoin` 0.00%
  - `Litecoin` 0.00%
  - `Bitcoin Cash` 0.00%


## Rate Limit
To guarantee the good performance of the service and its fair use. The API is **limited to receiving 120 requests per minute per IP**, which is sufficient for most use cases.

Payrobot.io is asynchronous in most API methods to communicate with your application through callbacks (webhooks), thus reducing unnecessary calls to the service.

**If the limit is exceeded, the IP will be banned for 1 minute.**

If you require an upper limit for your application, do not hesitate to contact us

## Considerations

  * Amounts in responses are expresed as `strings`
  
  * Wallets are not multi-currency, you have to create a different wallet per cryptocurrency (You can't store Litecoin in a Bitcoin wallet and vice-versa)
  
  * Payment forwarding has to be of the same type of currency (You can't forward a Bitcoin Cash payment to a Bitcoin address and vice-versa)
  


This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.0
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen

## Frameworks supported


- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

## Dependencies


- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:

```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

## Installation

Run the following command to generate the DLL

- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:

```csharp
using payrobot.Api;
using payrobot.Client;
using payrobot.Model;

```


## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out payrobot.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.


## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using payrobot.Api;
using payrobot.Client;
using payrobot.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration.Default.BasePath = "https://api.payrobot.io";
            var apiInstance = new PaymentApi(Configuration.Default);
            var currency = btc;  // string | Object Currency:   * `btc`: Bitcoin   * `ltc`: Litecoin   * `bch`: Bitcoin Cash 
            var type = 0;  // int | * `0: Receive and forward` payment is forwarded to a desired coin address once it's confirmed  * `1: Receive and store` payment is stored in a payrobot.io wallet 
            var destination = bc1qzlza4ke65fa2sqacjfu5vtwy8ar6x8xttgk999;  // string | * For `Receive and forward` payment is the `ADDRESS` where the payment is going to be forwarded as soon as it's confirmed. **ADDRESS HAS TO BE OF THE SAME TYPE OF CURRENCY**  * For `Receive and store` payment is the payrobot.io `WALLET ID` where the payment is going to be stored as soon as it's confirmed. **WALLET HAS TO BE OF THE SAME TYPE OF CURRENCY** 
            var amount = 0.0129;  // decimal | Amount of the payment
            var callback = https://your-callback-url.com;  // string | Your URL where payrobot.io will send the status of the payment (Webhook)
            var reference = Bill123;  // string | Optional custom reference to identify the payment (optional) 

            try
            {
                // Generate a new one-use address to receive a payment
                PaymentRequest result = apiInstance.CreatePayment(currency, type, destination, amount, callback, reference);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PaymentApi.CreatePayment: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

## Documentation for API Endpoints

All URIs are relative to *https://api.payrobot.io*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*PaymentApi* | [**CreatePayment**](docs/PaymentApi.md#createpayment) | **POST** /{currency}/payments | Generate a new one-use address to receive a payment
*PaymentApi* | [**GetPayment**](docs/PaymentApi.md#getpayment) | **GET** /{currency}/payments/{paymentId} | Get detailed information about a payment
*WalletApi* | [**CreateWallet**](docs/WalletApi.md#createwallet) | **POST** /{currency}/wallets | Create new wallet
*WalletApi* | [**CreateWalletSendRequest**](docs/WalletApi.md#createwalletsendrequest) | **POST** /{currency}/wallets/{walletId}/send-requests | Send funds from a wallet
*WalletApi* | [**GetWallet**](docs/WalletApi.md#getwallet) | **GET** /{currency}/wallets/{walletId} | Get Wallet information
*WalletApi* | [**GetWalletHistory**](docs/WalletApi.md#getwallethistory) | **GET** /{currency}/wallets/{walletId}/history | Get last transactions of wallet
*WalletApi* | [**GetWalletSendRequest**](docs/WalletApi.md#getwalletsendrequest) | **GET** /{currency}/wallets/{walletId}/send-requests/{requestId} | Obtain information of a send request


## Documentation for Models

 - [Model.AddressDetail](docs/AddressDetail.md)
 - [Model.CryptoCurrency](docs/CryptoCurrency.md)
 - [Model.ErrorResponse](docs/ErrorResponse.md)
 - [Model.PaymentRequest](docs/PaymentRequest.md)
 - [Model.Wallet](docs/Wallet.md)
 - [Model.WalletCreationInfo](docs/WalletCreationInfo.md)
 - [Model.WalletHistory](docs/WalletHistory.md)
 - [Model.WalletSendRequest](docs/WalletSendRequest.md)
 - [Model.WalletTransaction](docs/WalletTransaction.md)


## Documentation for Authorization

All endpoints do not require authorization.
