/* 
 * Payrobot
 *
 * # Introduction Accept, store, send or forward Bitcoin, Litecoin and Bitcoin Cash for your website or app and protect your privacy.  Supported crytocurrencies:   * BTC Bitcoin   * LTC Litecoin   * BCH Bitcoin Cash   ## Benefits    * **Anonymous** No personal details are required and transactions are mixed among all payments. You can forward your payments so as soon payrobot.io receives it forwards it to another address under your control.      * **No Registration** No registration, sign-up, application or form required to use payrobot.io      * **Easy Integration** Integrate your web / app through our simple RESTful API, you can accept payments with just one line of code!      * **Instant Payment Notification** Our servers notify your web / app the status of your payments. No polling, daemons or cronjobs required on your side!      * **Secure** Payrobot.io works with SSL and bank-level security protocols. Your transactions are safe!   ## Features **Payment Forward** Generate one-time addresses to recieve payments. Payrobot will notify your web /app through callbacks (webhooks) the status of the payment. As soon as it's confirmed the payment is forwarded to your desired address.  **Wallet** Receive, send payments and store your coins in a secure, private and anonymous wallet. All events are notified to your web / app through callbacks (webhooks). You can generate wallets with just one line of code without registration or further information  ## Fees **Only 0.90% per inbound transaction** (receive payments), NO HIDDEN FEES. All outbound transactions (send funds) are totally free.  Minimum fees applies, therefore the largest amount is going to be considered as fee either: `(inboundAmount*feePct)` or `the minimum fee`  **Inbound Fees (Receive payments)**    - `Bitcoin` 0.90% *(Minimum fee 0.00005 BTC)*   - `Litecoin` 0.90% *(Minimum fee 0.0005 LTC)*   - `Bitcoin Cash` 0.90% *(Minimum fee 0.0005 BCH)*     **Outbound Fees (Send funds)**    - `Bitcoin` 0.00%   - `Litecoin` 0.00%   - `Bitcoin Cash` 0.00%   ## Rate Limit To guarantee the good performance of the service and its fair use. The API is **limited to receiving 120 requests per minute per IP**, which is sufficient for most use cases.  Payrobot.io is asynchronous in most API methods to communicate with your application through callbacks (webhooks), thus reducing unnecessary calls to the service.  **If the limit is exceeded, the IP will be banned for 1 minute.**  If you require an upper limit for your application, do not hesitate to contact us  ## Considerations    * Amounts in responses are expresed as `strings`      * Wallets are not multi-currency, you have to create a different wallet per cryptocurrency (You can't store Litecoin in a Bitcoin wallet and vice-versa)      * Payment forwarding has to be of the same type of currency (You can't forward a Bitcoin Cash payment to a Bitcoin address and vice-versa)    
 *
 * The version of the OpenAPI document: 1.0
 * Contact: contact@payrobot.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = payrobot.Client.OpenAPIDateConverter;

namespace payrobot.Model
{
    /// <summary>
    /// PaymentRequest
    /// </summary>
    [DataContract]
    public partial class PaymentRequest :  IEquatable<PaymentRequest>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public CryptoCurrency? Currency { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentRequest" /> class.
        /// </summary>
        /// <param name="currency">currency.</param>
        /// <param name="paymentId">Unique identifier of the payment in selected currency.</param>
        /// <param name="address">One-use address for receive your client payment.</param>
        /// <param name="pin">PIN, it will be required if you need support with this payment.\\ *Note: It&#39;s provided only the first time you create the payment request*.</param>
        /// <param name="type">* &#x60;0: Receive and forward&#x60; payment is forwarded to a desired coin address once it&#39;s confirmed  * &#x60;1: Receive and store&#x60; payment is stored in a payrobot.io wallet .</param>
        /// <param name="amount">The payment amount your client has to send to the coin address.</param>
        /// <param name="callback">URL where payrobot.io will send the status of the payment (Webhook).</param>
        /// <param name="feePct">Fee percentage that will be discounted (default to 0.9M).</param>
        /// <param name="feeAmount">Fee amount that will be discounted.</param>
        /// <param name="finalAmount">Final amount of the transaction (Fee discount is already applied)   * For &#x60;Receive and forward&#x60; payment is the total amount to &#x60;forward&#x60; as soon as the payment is confirmed         * For &#x60;Receive and forward&#x60; payment is the total amount to &#x60;store&#x60; in the wallet as soon as the payment is confirmed.</param>
        /// <param name="destination">* For &#x60;Receive and forward&#x60; payment is the coin &#x60;ADDRESS&#x60; where the payment is going to be forwarded as soon as it&#39;s confirmed  * For &#x60;Receive and store&#x60; payment is the &#x60;WALLET ID&#x60; where the payment is going to be stored as soon as it&#39;s confirmed .</param>
        /// <param name="reference">Custom reference for payment identifying.</param>
        /// <param name="timestamp">Request creation date expressed in UNIX timestamp.</param>
        /// <param name="lastupdate">Last update expressed in UNIX timestamp.</param>
        /// <param name="status">Status of the payment:    * &#x60;0: Idle&#x60; payment has not been paid    * &#x60;1: Incomplete&#x60; payment is being paid partially    * &#x60;2: Confirming&#x60; payment has been received completely but it&#39;s not confirmed by network yet    * &#x60;3: Confirmed&#x60; payment has been paid completely and it has at least &#x60;1&#x60; confirmation by network .</param>
        /// <param name="error">&#x60;true&#x60; is there was a problem. &#x60;false&#x60; if not .</param>
        public PaymentRequest(CryptoCurrency? currency = default(CryptoCurrency?), string paymentId = default(string), string address = default(string), string pin = default(string), int type = default(int), string amount = default(string), string callback = default(string), decimal feePct = 0.9M, string feeAmount = default(string), string finalAmount = default(string), string destination = default(string), string reference = default(string), int timestamp = default(int), int lastupdate = default(int), int status = default(int), bool error = default(bool))
        {
            this.Currency = currency;
            this.PaymentId = paymentId;
            this.Address = address;
            this.Pin = pin;
            this.Type = type;
            this.Amount = amount;
            this.Callback = callback;
            // use default value if no "feePct" provided
            if (feePct == null)
            {
                this.FeePct = 0.9M;
            }
            else
            {
                this.FeePct = feePct;
            }
            this.FeeAmount = feeAmount;
            this.FinalAmount = finalAmount;
            this.Destination = destination;
            this.Reference = reference;
            this.Timestamp = timestamp;
            this.Lastupdate = lastupdate;
            this.Status = status;
            this.Error = error;
        }
        

        /// <summary>
        /// Unique identifier of the payment in selected currency
        /// </summary>
        /// <value>Unique identifier of the payment in selected currency</value>
        [DataMember(Name="paymentId", EmitDefaultValue=false)]
        public string PaymentId { get; set; }

        /// <summary>
        /// One-use address for receive your client payment
        /// </summary>
        /// <value>One-use address for receive your client payment</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// PIN, it will be required if you need support with this payment.\\ *Note: It&#39;s provided only the first time you create the payment request*
        /// </summary>
        /// <value>PIN, it will be required if you need support with this payment.\\ *Note: It&#39;s provided only the first time you create the payment request*</value>
        [DataMember(Name="pin", EmitDefaultValue=false)]
        public string Pin { get; set; }

        /// <summary>
        /// * &#x60;0: Receive and forward&#x60; payment is forwarded to a desired coin address once it&#39;s confirmed  * &#x60;1: Receive and store&#x60; payment is stored in a payrobot.io wallet 
        /// </summary>
        /// <value>* &#x60;0: Receive and forward&#x60; payment is forwarded to a desired coin address once it&#39;s confirmed  * &#x60;1: Receive and store&#x60; payment is stored in a payrobot.io wallet </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public int Type { get; set; }

        /// <summary>
        /// The payment amount your client has to send to the coin address
        /// </summary>
        /// <value>The payment amount your client has to send to the coin address</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public string Amount { get; set; }

        /// <summary>
        /// URL where payrobot.io will send the status of the payment (Webhook)
        /// </summary>
        /// <value>URL where payrobot.io will send the status of the payment (Webhook)</value>
        [DataMember(Name="callback", EmitDefaultValue=false)]
        public string Callback { get; set; }

        /// <summary>
        /// Fee percentage that will be discounted
        /// </summary>
        /// <value>Fee percentage that will be discounted</value>
        [DataMember(Name="feePct", EmitDefaultValue=false)]
        public decimal FeePct { get; set; }

        /// <summary>
        /// Fee amount that will be discounted
        /// </summary>
        /// <value>Fee amount that will be discounted</value>
        [DataMember(Name="feeAmount", EmitDefaultValue=false)]
        public string FeeAmount { get; set; }

        /// <summary>
        /// Final amount of the transaction (Fee discount is already applied)   * For &#x60;Receive and forward&#x60; payment is the total amount to &#x60;forward&#x60; as soon as the payment is confirmed         * For &#x60;Receive and forward&#x60; payment is the total amount to &#x60;store&#x60; in the wallet as soon as the payment is confirmed
        /// </summary>
        /// <value>Final amount of the transaction (Fee discount is already applied)   * For &#x60;Receive and forward&#x60; payment is the total amount to &#x60;forward&#x60; as soon as the payment is confirmed         * For &#x60;Receive and forward&#x60; payment is the total amount to &#x60;store&#x60; in the wallet as soon as the payment is confirmed</value>
        [DataMember(Name="finalAmount", EmitDefaultValue=false)]
        public string FinalAmount { get; set; }

        /// <summary>
        /// * For &#x60;Receive and forward&#x60; payment is the coin &#x60;ADDRESS&#x60; where the payment is going to be forwarded as soon as it&#39;s confirmed  * For &#x60;Receive and store&#x60; payment is the &#x60;WALLET ID&#x60; where the payment is going to be stored as soon as it&#39;s confirmed 
        /// </summary>
        /// <value>* For &#x60;Receive and forward&#x60; payment is the coin &#x60;ADDRESS&#x60; where the payment is going to be forwarded as soon as it&#39;s confirmed  * For &#x60;Receive and store&#x60; payment is the &#x60;WALLET ID&#x60; where the payment is going to be stored as soon as it&#39;s confirmed </value>
        [DataMember(Name="destination", EmitDefaultValue=false)]
        public string Destination { get; set; }

        /// <summary>
        /// Custom reference for payment identifying
        /// </summary>
        /// <value>Custom reference for payment identifying</value>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public string Reference { get; set; }

        /// <summary>
        /// Request creation date expressed in UNIX timestamp
        /// </summary>
        /// <value>Request creation date expressed in UNIX timestamp</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public int Timestamp { get; set; }

        /// <summary>
        /// Last update expressed in UNIX timestamp
        /// </summary>
        /// <value>Last update expressed in UNIX timestamp</value>
        [DataMember(Name="lastupdate", EmitDefaultValue=false)]
        public int Lastupdate { get; set; }

        /// <summary>
        /// Status of the payment:    * &#x60;0: Idle&#x60; payment has not been paid    * &#x60;1: Incomplete&#x60; payment is being paid partially    * &#x60;2: Confirming&#x60; payment has been received completely but it&#39;s not confirmed by network yet    * &#x60;3: Confirmed&#x60; payment has been paid completely and it has at least &#x60;1&#x60; confirmation by network 
        /// </summary>
        /// <value>Status of the payment:    * &#x60;0: Idle&#x60; payment has not been paid    * &#x60;1: Incomplete&#x60; payment is being paid partially    * &#x60;2: Confirming&#x60; payment has been received completely but it&#39;s not confirmed by network yet    * &#x60;3: Confirmed&#x60; payment has been paid completely and it has at least &#x60;1&#x60; confirmation by network </value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int Status { get; set; }

        /// <summary>
        /// &#x60;true&#x60; is there was a problem. &#x60;false&#x60; if not 
        /// </summary>
        /// <value>&#x60;true&#x60; is there was a problem. &#x60;false&#x60; if not </value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public bool Error { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentRequest {\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  PaymentId: ").Append(PaymentId).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Pin: ").Append(Pin).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Callback: ").Append(Callback).Append("\n");
            sb.Append("  FeePct: ").Append(FeePct).Append("\n");
            sb.Append("  FeeAmount: ").Append(FeeAmount).Append("\n");
            sb.Append("  FinalAmount: ").Append(FinalAmount).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Lastupdate: ").Append(Lastupdate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PaymentRequest);
        }

        /// <summary>
        /// Returns true if PaymentRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.PaymentId == input.PaymentId ||
                    (this.PaymentId != null &&
                    this.PaymentId.Equals(input.PaymentId))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Pin == input.Pin ||
                    (this.Pin != null &&
                    this.Pin.Equals(input.Pin))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Callback == input.Callback ||
                    (this.Callback != null &&
                    this.Callback.Equals(input.Callback))
                ) && 
                (
                    this.FeePct == input.FeePct ||
                    (this.FeePct != null &&
                    this.FeePct.Equals(input.FeePct))
                ) && 
                (
                    this.FeeAmount == input.FeeAmount ||
                    (this.FeeAmount != null &&
                    this.FeeAmount.Equals(input.FeeAmount))
                ) && 
                (
                    this.FinalAmount == input.FinalAmount ||
                    (this.FinalAmount != null &&
                    this.FinalAmount.Equals(input.FinalAmount))
                ) && 
                (
                    this.Destination == input.Destination ||
                    (this.Destination != null &&
                    this.Destination.Equals(input.Destination))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.Lastupdate == input.Lastupdate ||
                    (this.Lastupdate != null &&
                    this.Lastupdate.Equals(input.Lastupdate))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.PaymentId != null)
                    hashCode = hashCode * 59 + this.PaymentId.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Pin != null)
                    hashCode = hashCode * 59 + this.Pin.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Callback != null)
                    hashCode = hashCode * 59 + this.Callback.GetHashCode();
                if (this.FeePct != null)
                    hashCode = hashCode * 59 + this.FeePct.GetHashCode();
                if (this.FeeAmount != null)
                    hashCode = hashCode * 59 + this.FeeAmount.GetHashCode();
                if (this.FinalAmount != null)
                    hashCode = hashCode * 59 + this.FinalAmount.GetHashCode();
                if (this.Destination != null)
                    hashCode = hashCode * 59 + this.Destination.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.Lastupdate != null)
                    hashCode = hashCode * 59 + this.Lastupdate.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}