﻿namespace Tulpep.PayULibrary.Cross
{
    public static class Constants
    {
        #region Infraestructure Strings
        public const string DefaultTestQueriesConnectionUrl = "https:///stg.api.payulatam.com/reports-api/4.0/service.cgi";
        public const string DefaultProductionQueriesConnectionUrl = "https:///api.payulatam.com/reports-api/4.0/service.cgi";
        public const string TestAPILogin = "11959c415b33d0c";
        public const string TestAPIKey = "6u39nqhq8ftd0hlvnjfs66eh8c";
        public const string TestMerchantId = "500238";
        public const string MerchantId = "509269";
        public const string APIKey = "5ck1kmok44ko09lqnni384ev58";
        public const string APILogin = "6bf6d64e593f136";
        public const string TestAccountId = "500538";
        public const string DefaultProductionPaymentsConnectionUrl = "https:///api.payulatam.com/payments-api/4.0/service.cgi";
        public const string DefaultTestPaymentsConnectionUrl = "https:///stg.api.payulatam.com/payments-api/4.0/service.cgi";
        public const string AccountId = "510410";
        #endregion

        #region common Status
        ///<summary>
        ///Each query has proccessed successful.
        ///</summary>
        public const string SUCCESS = "SUCCESS";
        ///<summary>
        ///Used to ping all services.
        ///</summary>
        public const string PING = "PING";
        ///<summary>
        ///Each transaction was approved.
        ///</summary>
        public const string APPROVED = "APPROVED";
        ///<summary>
        ///There was a general error.
        ///</summary>
        public const string ERROR = "ERROR";
        ///<summary>
        /// Rejected transaction OR The last transaction of the order was declined.
        ///</summary>
        public const string DECLINED = "DECLINED";
        #endregion

        #region Response code transaction
        ///<summary>
        ///The transaction was rejected by the anti-fraud system.
        ///</summary>
        public const string ANTIFRAUD_REJECTED = "ANTIFRAUD_REJECTED";
        ///<summary>
        ///The financial network rejected the transaction.
        ///</summary>
        public const string PAYMENT_NETWORK_REJECTED = "PAYMENT_NETWORK_REJECTED";
        ///<summary>
        ///The transaction was declined by the bank or financial network because of an error.
        ///</summary>
        public const string ENTITY_DECLINED = "ENTITY_DECLINED";
        ///<summary>
        ///An error occurred in the system trying to process the payment.
        ///</summary>
        public const string INTERNAL_PAYMENT_PROVIDER_ERROR = "INTERNAL_PAYMENT_PROVIDER_ERROR";
        ///<summary>
        ///The payment provider was not active.
        ///</summary>
        public const string INACTIVE_PAYMENT_PROVIDER = "INACTIVE_PAYMENT_PROVIDER";
        ///<summary>
        ///The financial network reported an authentication error.
        ///</summary>
        public const string DIGITAL_CERTIFICATE_NOT_FOUND = "DIGITAL_CERTIFICATE_NOT_FOUND";
        ///<summary>
        ///The security code or expiration date was invalid.
        ///</summary>
        public const string INVALID_EXPIRATION_DATE_OR_SECURITY_CODE = "INVALID_EXPIRATION_DATE_OR_SECURITY_CODE";
        ///<summary>
        ///The account had insufficient funds.
        ///</summary>
        public const string INSUFFICIENT_FUNDS = "INSUFFICIENT_FUNDS";
        ///<summary>
        ///The credit card was not authorized for internet transactions.
        ///</summary>
        public const string CREDIT_CARD_NOT_AUTHORIZED_FOR_INTERNET_TRANSACTIONS = "CREDIT_CARD_NOT_AUTHORIZED_FOR_INTERNET_TRANSACTIONS";
        ///<summary>
        ///The financial network reported that the transaction was invalid.
        ///</summary>
        public const string INVALID_TRANSACTION = "INVALID_TRANSACTION";
        ///<summary>
        ///The card is invalid.
        ///</summary>
        public const string INVALID_CARD = "INVALID_CARD";
        ///<summary>
        ///The card has expired.
        ///</summary>
        public const string EXPIRED_CARD = "EXPIRED_CARD";
        ///<summary>
        ///The card has a restriction.
        ///</summary>
        public const string RESTRICTED_CARD = "RESTRICTED_CARD";
        ///<summary>
        ///You should contact the bank.
        ///</summary>
        public const string REPEAT_TRANSACTION = "REPEAT_TRANSACTION";
        ///<summary>
        ///The financial network reported a communication error with the bank.
        ///</summary>
        public const string ENTITY_MESSAGING_ERROR = "ENTITY_MESSAGING_ERROR";
        ///<summary>
        ///The bank was not available.
        ///</summary>
        public const string BANK_UNREACHABLE = "BANK_UNREACHABLE";
        ///<summary>
        ///The transaction exceeds the amount set by the bank.
        ///</summary>
        public const string EXCEEDED_AMOUNT = "EXCEEDED_AMOUNT";
        ///<summary>
        ///The transaction was not accepted by the bank for some reason.
        ///</summary>
        public const string NOT_ACCEPTED_TRANSACTION = "NOT_ACCEPTED_TRANSACTION";
        ///<summary>
        ///An error occurred converting the amounts to the payment currency.
        ///</summary>
        public const string ERROR_CONVERTING_TRANSACTION_AMOUNTS = "ERROR_CONVERTING_TRANSACTION_AMOUNTS";
        ///<summary>
        ///The transaction expired.
        ///</summary>
        public const string EXPIRED_TRANSACTION = "EXPIRED_TRANSACTION";
        ///<summary>
        ///The transaction was stopped and must be revised, this can occur because of security filters.
        ///</summary>
        public const string PENDING_TRANSACTION_REVIEW = "PENDING_TRANSACTION_REVIEW";
        ///<summary>
        ///The transaction is subject to confirmation.
        ///</summary>
        public const string PENDING_TRANSACTION_CONFIRMATION = "PENDING_TRANSACTION_CONFIRMATION";
        ///<summary>
        ///The transaction is subject to be transmitted to the financial network. 
        ///This usually applies to transactions with cash payment means.
        ///</summary>
        public const string PENDING_TRANSACTION_TRANSMISSION = "PENDING_TRANSACTION_TRANSMISSION";
        ///<summary>
        ///The message returned by the financial network is inconsistent.
        ///</summary>
        public const string PAYMENT_NETWORK_BAD_RESPONSE = "PAYMENT_NETWORK_BAD_RESPONSE";
        ///<summary>
        ///Could not connect to the financial network.
        ///</summary>
        public const string PAYMENT_NETWORK_NO_CONNECTION = "PAYMENT_NETWORK_NO_CONNECTION";
        ///<summary>
        ///Financial Network did not respond.
        ///</summary>
        public const string PAYMENT_NETWORK_NO_RESPONSE = "PAYMENT_NETWORK_NO_RESPONSE";
        ///<summary>
        ///Transactions clinic: internal handling code.
        ///</summary>
        public const string FIX_NOT_REQUIRED = "FIX_NOT_REQUIRED";
        ///<summary>
        ///Transactions clinic: internal handling code. Only applies to Query API.
        ///</summary>
        public const string AUTOMATICALLY_FIXED_AND_SUCCESS_REVERSAL = "AUTOMATICALLY_FIXED_AND_SUCCESS_REVERSAL";
        ///<summary>
        ///Transactions clinic: internal handling code. Only applies to Query API.
        ///</summary>
        public const string AUTOMATICALLY_FIXED_AND_UNSUCCESS_REVERSAL = "AUTOMATICALLY_FIXED_AND_UNSUCCESS_REVERSAL";
        ///<summary>
        ///Transactions clinic: internal handling code. Only applies to Query API.
        ///</summary>
        public const string AUTOMATIC_FIXED_NOT_SUPPORTED = "AUTOMATIC_FIXED_NOT_SUPPORTED";
        ///<summary>
        ///Transactions clinic: internal handling code. Only applies to Query API.
        ///</summary>
        public const string NOT_FIXED_FOR_ERROR_STATE = "NOT_FIXED_FOR_ERROR_STATE";
        ///<summary>
        ///Transactions clinic: internal handling code. Only applies to Query API.
        ///</summary>
        public const string ERROR_FIXING_AND_REVERSING = "ERROR_FIXING_AND_REVERSING";
        ///<summary>
        ///Transactions clinic: internal handling code. Only applies to Query API.
        ///</summary>
        public const string ERROR_FIXING_INCOMPLETE_DATA = "ERROR_FIXING_INCOMPLETE_DATA";
        #endregion

        #region  Command accepted for query api
        ///<summary>
        ///Used to query an order using its identifier.
        ///</summary>
        public const string ORDER_DETAIL = "ORDER_DETAIL";
        ///<summary>
        ///Used to query an order using its reference code.
        ///</summary>
        public const string ORDER_DETAIL_BY_REFERENCE_CODE = "ORDER_DETAIL_BY_REFERENCE_CODE";
        ///<summary>
        ///Used to check the response of a transaction.
        ///</summary>
        public const string TRANSACTION_RESPONSE_DETAIL = "TRANSACTION_RESPONSE_DETAIL";
        #endregion

        #region  Commands accepted by the payment api
        ///<summary>
        ///Used to send transactions of any kind.
        ///</summary>
        public const string SUBMIT_TRANSACTION = "SUBMIT_TRANSACTION";
        ///<summary>
        ///Used to query the shop’s available payment methods.
        ///</summary>
        public const string GET_PAYMENT_METHODS = "GET_PAYMENT_METHODS";
        ///<summary>
        ///It is used to obtain the bank list for PSE transactions.
        ///</summary>
        public const string GET_BANKS_LIST = "GET_BANKS_LIST";
        #endregion

        #region Accepted currencies
        ///<summary>
        /// Argentine Peso
        ///</summary>
        public const string ARS = "ARS";
        ///<summary>
        /// Brazilian Real
        ///</summary>
        public const string BRL = "BRL";
        ///<summary>
        /// Chilean Peso
        ///</summary>
        public const string CLP = "CLP";
        ///<summary>
        /// Colombian Peso
        ///</summary>
        public const string COP = "COP";
        ///<summary>
        /// Mexican Peso
        ///</summary>
        public const string MXN = "MXN";
        ///<summary>
        /// US Dollar
        ///</summary>
        public const string USD = "USD";
        ///<summary>
        /// Peruvian Nuevo Sol
        ///</summary>
        public const string PEN = "PEN";
        #endregion

        #region Transaction state
        ///<summary>
        /// Expired transaction
        ///</summary>
        public const string EXPIRED = "EXPIRED";
        ///<summary>
        /// Pending transaction or in validation
        ///</summary>
        public const string PENDING = "PENDING";
        ///<summary>
        ///   Transaction sent to the financial institution and for some reason processing did not finish.Only applies to query API.
        ///</summary>
        public const string SUBMITTED = "SUBMITTED";
        #endregion

        #region Order status
        ///<summary>
        ///The order was just created in the system
        ///</summary>
        public const string NEW = "NEW";
        ///<summary>
        ///The order is being processed.
        ///</summary>
        public const string IN_PROGRESS = "IN_PROGRESS";
        ///<summary>
        ///  The last transaction of the order was an approved authorization.
        ///</summary>
        public const string AUTHORIZED = "AUTHORIZED";
        ///<summary>
        /// The last transaction of the order was an approved capture.
        ///</summary>
        public const string CAPTURED = "CAPTURED";
        ///<summary>
        /// The last transaction of the order was an approved cancellation.
        ///</summary>
        public const string CANCELLED = "CANCELLED";
        ///<summary>
        ///The last transaction of the order was an approved refund.
        ///</summary>
        public const string REFUNDED = "REFUNDED";
        #endregion

        #region  Supported languages
        ///        Iso code 639	
        ///<summary>
        ///English
        ///</summary>
        public const string en = "en";
        ///<summary>
        ///Spanish
        ///</summary>
        public const string es = "es";
        ///<summary>
        ///Portuguese
        ///</summary>
        public const string pt = "pt";
        #endregion

        #region  Payment method
        ///<summary>
        ///Common for all countries
        ///. Panama
        ///Only VISA MASTERCARD
        ///</summary>
        public const string VISA = "VISA";
        ///<summary>
        ///Common for all countries
        ///. Panama
        ///Only VISA MASTERCARD
        ///</summary>
        public const string MASTERCARD = "MASTERCARD";
        ///<summary>
        ///Common
        ///</summary>
        public const string AMEX = "AMEX";
        ///<summary>
        ///Common 
        ///</summary>
        public const string DINERS = "DINERS";
        ///<summary>
        ///Argentina
        ///</summary>
        public const string PAGOFACIL = "PAGOFACIL";
        ///<summary>
        ///Argentina
        ///</summary>
        public const string CABAL = "CABAL";
        ///<summary>
        ///Argentina
        ///</summary>
        public const string NARANJA = "NARANJA";
        ///<summary>
        ///Argentina
        ///</summary>
        public const string SHOPPING = "SHOPPING";
        ///<summary>
        ///Argentina
        ///</summary>
        public const string COBRO_EXPRESS = "COBRO_EXPRESS";
        ///<summary>
        ///Argentina
        ///</summary>
        public const string RAPIPAGO = "RAPIPAGO";
        ///<summary>
        ///Argentina
        ///</summary>
        public const string CENCOSUD = "CENCOSUD";
        ///<summary>
        ///Argentina
        ///</summary>
        public const string ARGENCARD = "ARGENCARD";
        ///<summary>
        ///Argentina
        ///</summary>
        public const string BAPRO = "BAPRO";
        ///<summary>
        ///Argentina
        ///</summary>
        public const string RIPSA = "RIPSA";
        ///<summary>
        /// Brazil
        ///</summary>
        public const string BOLETO_BANCARIO = "BOLETO_BANCARIO";
        ///<summary>
        /// Brazil
        ///</summary>
        public const string ELO = "ELO";
        ///<summary>
        /// Brazil
        ///</summary>
        public const string HIPERCARD = "HIPERCARD";
        ///<summary>
        ///Chile
        ///</summary>
        public const string TRANSBANK = "TRANSBANK";
        ///<summary>
        /// Colombia
        ///</summary>
        public const string BALOTO = "BALOTO";
        ///<summary>
        /// Colombia
        ///</summary>
        public const string BANK_REFERENCED = "BANK_REFERENCED";
        ///<summary>
        /// Colombia
        ///</summary>
        public const string PSE = "PSE";
        ///<summary>
        /// Colombia
        ///</summary>
        public const string EFECTY = "EFECTY";
        ///<summary>
        /// México
        ///</summary>
        public const string SANTANDER = "SANTANDER";
        ///<summary>
        /// México
        ///</summary>
        public const string BANCOMER = "BANCOMER";
        ///<summary>
        /// México
        ///</summary>
        public const string IXE = "IXE";
        ///<summary>
        /// México
        ///</summary>
        public const string SCOTIABANK = "SCOTIABANK";
        ///<summary>
        /// México
        ///</summary>
        public const string BANAMEX = "BANAMEX";
        ///<summary>
        /// México
        ///</summary>
        public const string OXXO = "OXXO";
        ///<summary>
        /// México
        ///</summary>
        public const string SEVEN_ELEVEN = "SEVEN_ELEVEN";
        ///<summary>
        /// Peru
        ///</summary>
        public const string BCP = "BCP";
        #endregion

        #region Countries of payment
        ///<summary>
        /// Brazil
        ///</summary>
        public const string BR = "BR";
        ///<summary>
        /// Argentina
        ///</summary>
        public const string AR = "AR";
        ///<summary>
        ///Colombia
        ///</summary>
        public const string CO = "CO";
        ///<summary>
        /// Mexico
        ///</summary>
        public const string MX = "BR";
        ///<summary>
        /// Panama
        ///</summary>
        public const string PA = "PA";
        ///<summary>
        /// Peru
        ///</summary>
        public const string PE = "PE";
        #endregion

        #region Transaction types
        ///<summary>
        /// Authorization transaction
        ///</summary>
        public const string AUTHORIZATION = "AUTHORIZATION";
        ///<summary>
        /// Authorization and capture transaction
        ///</summary>
        public const string AUTHORIZATION_AND_CAPTURE = "AUTHORIZATION_AND_CAPTURE";
        ///<summary>
        /// Capture Transaction
        ///</summary>
        public const string CAPTURE = "CAPTURE";
        ///<summary>
        /// Cancellation transaction of an authorization
        ///</summary>
        public const string VOID = "VOID";
        ///<summary>
        /// Refund transaction or cancellation of a capture
        ///</summary>
        public const string REFUND = "REFUND";
        #endregion
    }
}