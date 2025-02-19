# Altairis.Fakturoid.Client.dll v.3.0.0.0 API documentation

# All types

|   |   |   |
|---|---|---|
| [FakturoidContext Class](#fakturoidcontext-class) | [FakturoidInventoryItem Class](#fakturoidinventoryitem-class) | [FakturoidWebhook Class](#fakturoidwebhook-class) |
| [FakturoidException Class](#fakturoidexception-class) | [FakturoidInventoryMove Class](#fakturoidinventorymove-class) | [ExpensePaymentStatus Enum](#expensepaymentstatus-enum) |
| [FakturoidExtensionMethods Class](#fakturoidextensionmethods-class) | [FakturoidInventoryMoveDocument Class](#fakturoidinventorymovedocument-class) | [ExpenseStatusCondition Enum](#expensestatuscondition-enum) |
| [RecurringGenerator Class](#recurringgenerator-class) | [FakturoidInvoice Class](#fakturoidinvoice-class) | [FakturoidBankAccountsProxy Class](#fakturoidbankaccountsproxy-class) |
| [FakturoidAccessToken Class](#fakturoidaccesstoken-class) | [FakturoidInvoiceMessage Class](#fakturoidinvoicemessage-class) | [FakturoidEntityProxy Class](#fakturoidentityproxy-class) |
| [FakturoidAccount Class](#fakturoidaccount-class) | [FakturoidInvoicePaidAdvance Class](#fakturoidinvoicepaidadvance-class) | [FakturoidEventsProxy Class](#fakturoideventsproxy-class) |
| [FakturoidAttachment Class](#fakturoidattachment-class) | [FakturoidInvoicePayment Class](#fakturoidinvoicepayment-class) | [FakturoidExpensesProxy Class](#fakturoidexpensesproxy-class) |
| [FakturoidAttachmentUpload Class](#fakturoidattachmentupload-class) | [FakturoidLegacyBankDetails Class](#fakturoidlegacybankdetails-class) | [FakturoidInvoicesProxy Class](#fakturoidinvoicesproxy-class) |
| [FakturoidBankAccount Class](#fakturoidbankaccount-class) | [FakturoidLine Class](#fakturoidline-class) | [FakturoidNumberFormatsProxy Class](#fakturoidnumberformatsproxy-class) |
| [FakturoidEvent Class](#fakturoidevent-class) | [FakturoidNumberFormat Class](#fakturoidnumberformat-class) | [FakturoidSubjectsProxy Class](#fakturoidsubjectsproxy-class) |
| [FakturoidEventUser Class](#fakturoideventuser-class) | [FakturoidRelatedObject Class](#fakturoidrelatedobject-class) | [FakturoidTodosProxy Class](#fakturoidtodosproxy-class) |
| [FakturoidExpense Class](#fakturoidexpense-class) | [FakturoidSubject Class](#fakturoidsubject-class) | [InvoiceMessageType Enum](#invoicemessagetype-enum) |
| [FakturoidExpensePayment Class](#fakturoidexpensepayment-class) | [FakturoidTodo Class](#fakturoidtodo-class) | [InvoicePaymentStatus Enum](#invoicepaymentstatus-enum) |
| [FakturoidGenerator Class](#fakturoidgenerator-class) | [FakturoidUser Class](#fakturoiduser-class) | [InvoiceStatusCondition Enum](#invoicestatuscondition-enum) |
| [FakturoidInboxFile Class](#fakturoidinboxfile-class) | [FakturoidUserAccount Class](#fakturoiduseraccount-class) | [InvoiceTypeCondition Enum](#invoicetypecondition-enum) |
| [FakturoidInventory Class](#fakturoidinventory-class) | [FakturoidVatRateSummary Class](#fakturoidvatratesummary-class) |   |
# FakturoidContext Class

Namespace: Altairis.Fakturoid.Client

Class representing connection to Fakturoid API, holds authentication information etc.

## Properties

| Name | Type | Summary |
|---|---|---|
| **AccountName** | string | Gets the Fakturoid account name. |
| **ClientId** | string | Gets the Fakturoid account email address. |
| **ClientSecret** | string | Gets the Fakturoid authentication token. |
| **UserAgent** | string | Gets the User-Agent header used for HTTP requests. |
| **BankAccounts** | [FakturoidBankAccountsProxy](#fakturoidbankaccountsproxy-class) | Gets the bank accounts. |
| **NumberFormats** | [FakturoidNumberFormatsProxy](#fakturoidnumberformatsproxy-class) | Gets the number formats. |
| **Subjects** | [FakturoidSubjectsProxy](#fakturoidsubjectsproxy-class) | Gets the subjects. |
| **Todos** | [FakturoidTodosProxy](#fakturoidtodosproxy-class) | Gets the todos. |
| **Events** | [FakturoidEventsProxy](#fakturoideventsproxy-class) | Gets the events. |
## Constructors

| Name | Summary |
|---|---|
| [**FakturoidContext(string accountName, string clientId, string clientSecret, string userAgent)**](#fakturoidcontextstring-accountname-string-clientid-string-clientsecret-string-useragent) | Initializes a new instance of the **Altairis.Fakturoid.Client.FakturoidContext** class. |
## Methods

| Name | Returns | Summary |
|---|---|---|
| [**GetAccountInfoAsync()**](#getaccountinfoasync) | Task\<[FakturoidAccount](#fakturoidaccount-class)\> | Gets the account information. |
## Constructors

### FakturoidContext(string accountName, string clientId, string clientSecret, string userAgent)

Initializes a new instance of the **Altairis.Fakturoid.Client.FakturoidContext** class.

| Parameter | Type | Description |
|---|---|---|
| accountName | string | Account name (accountName). |
| clientId | string | The client ID for OAuth 2 Client Credentials Flow. |
| clientSecret | string | The client secret for OAuth 2 Client Credentials Flow. |
| userAgent | string | The User-Agent HTTP header value. |


## Methods

### GetAccountInfoAsync()

Gets the account information.



### Returns

Task<[FakturoidAccount](#fakturoidaccount-class)>

Instance of **Altairis.Fakturoid.Client.Models.FakturoidAccount** class containing the account information.

# FakturoidException Class

Namespace: Altairis.Fakturoid.Client

Base class: Exception

The exception representing error returned by Fakturoid API.

## Properties

| Name | Type | Summary |
|---|---|---|
| **Response** | HttpResponseMessage | Gets or sets the related HTTP response object. |
| **ResponseBody** | string | Gets the HTTP response body as string. |
| **Errors** | IEnumerable\<KeyValuePair\<string, string\>\> | Gets the errors returned by Fakturoid API. |
| **TargetSite** | MethodBase |  |
| **StackTrace** | string |  |
| **Message** | string |  |
| **Data** | IDictionary |  |
| **InnerException** | Exception |  |
| **HelpLink** | string |  |
| **Source** | string |  |
| **HResult** | int |  |
## Constructors

| Name | Summary |
|---|---|
| [**FakturoidException()**](#fakturoidexception) | Initializes a new instance of the **Altairis.Fakturoid.Client.FakturoidException** class. |
| [**FakturoidException(string message)**](#fakturoidexceptionstring-message) | Initializes a new instance of the **Altairis.Fakturoid.Client.FakturoidException** class. |
| [**FakturoidException(HttpResponseMessage response)**](#fakturoidexceptionhttpresponsemessage-response) | Initializes a new instance of the **Altairis.Fakturoid.Client.FakturoidException** class. |
| [**FakturoidException(string format, Object[] args)**](#fakturoidexceptionstring-format-object-args) | Initializes a new instance of the **Altairis.Fakturoid.Client.FakturoidException** class. |
| [**FakturoidException(string message, Exception innerException)**](#fakturoidexceptionstring-message-exception-innerexception) | Initializes a new instance of the **Altairis.Fakturoid.Client.FakturoidException** class. |
| [**FakturoidException(string format, Exception innerException, Object[] args)**](#fakturoidexceptionstring-format-exception-innerexception-object-args) | Initializes a new instance of the **Altairis.Fakturoid.Client.FakturoidException** class. |
## Methods

| Name | Returns | Summary |
|---|---|---|
| [**GetObjectData(SerializationInfo info, StreamingContext context)**](#getobjectdataserializationinfo-info-streamingcontext-context) | void | Sets the **System.Runtime.Serialization.SerializationInfo** with information about the exception. |
## Constructors

### FakturoidException()

Initializes a new instance of the **Altairis.Fakturoid.Client.FakturoidException** class.



### FakturoidException(string message)

Initializes a new instance of the **Altairis.Fakturoid.Client.FakturoidException** class.

| Parameter | Type | Description |
|---|---|---|
| message | string | The message that describes the error. |


### FakturoidException(HttpResponseMessage response)

Initializes a new instance of the **Altairis.Fakturoid.Client.FakturoidException** class.

| Parameter | Type | Description |
|---|---|---|
| response | HttpResponseMessage | The HTTP response to get exception information from. |


### FakturoidException(string format, Object[] args)

Initializes a new instance of the **Altairis.Fakturoid.Client.FakturoidException** class.

| Parameter | Type | Description |
|---|---|---|
| format | string | The format. |
| args | Object[] | The args. |


### FakturoidException(string message, Exception innerException)

Initializes a new instance of the **Altairis.Fakturoid.Client.FakturoidException** class.

| Parameter | Type | Description |
|---|---|---|
| message | string | The error message that explains the reason for the exception. |
| innerException | Exception | The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified. |


### FakturoidException(string format, Exception innerException, Object[] args)

Initializes a new instance of the **Altairis.Fakturoid.Client.FakturoidException** class.

| Parameter | Type | Description |
|---|---|---|
| format | string | The format. |
| innerException | Exception | The inner exception. |
| args | Object[] | The args. |


## Methods

### GetObjectData(SerializationInfo info, StreamingContext context)

Sets the **System.Runtime.Serialization.SerializationInfo** with information about the exception.

| Parameter | Type | Description |
|---|---|---|
| info | SerializationInfo | The **System.Runtime.Serialization.SerializationInfo** that holds the serialized object data about the exception being thrown. |
| context | StreamingContext | The **System.Runtime.Serialization.StreamingContext** that contains contextual information about the source or destination. |


# FakturoidExtensionMethods Class

Namespace: Altairis.Fakturoid.Client


## Methods

| Name | Returns | Summary |
|---|---|---|
| [**EnsureFakturoidSuccess(HttpResponseMessage r)**](#ensurefakturoidsuccesshttpresponsemessage-r) | void |  |
| [**FakturoidPatchAsJsonAsync(HttpClient client, string requestUri, T value)**](#fakturoidpatchasjsonasynchttpclient-client-string-requesturi-t-value) | Task\<HttpResponseMessage\> |  |
| [**FakturoidPostAsJsonAsync(HttpClient client, string requestUri, T value)**](#fakturoidpostasjsonasynchttpclient-client-string-requesturi-t-value) | Task\<HttpResponseMessage\> |  |
| [**FakturoidReadAsAsync(HttpContent content)**](#fakturoidreadasasynchttpcontent-content) | Task\<T\> |  |
## Methods

### EnsureFakturoidSuccess(HttpResponseMessage r)




### FakturoidPatchAsJsonAsync(HttpClient client, string requestUri, T value)




### Returns

Task<HttpResponseMessage>


### FakturoidPostAsJsonAsync(HttpClient client, string requestUri, T value)




### Returns

Task<HttpResponseMessage>


### FakturoidReadAsAsync(HttpContent content)




### Returns

Task<T>


# RecurringGenerator Class

Namespace: Altairis.Fakturoid.Client

Recurring invoice generator.

## Properties

| Name | Type | Summary |
|---|---|---|
| **Id** | int | Unique identifier in Fakturoid. |
| **CustomId** | string | Identifier in your application. |
| **Name** | string | Generator name. |
| **Active** | bool | Generator is active or paused. |
| **Proforma** | bool | Issue invoice as a proforma. |
| **Paypal** | bool | Show PayPal pay button on invoice. |
| **Gopay** | bool | Show GoPay pay button on invoice. |
| **StartDate** | DateTime | Start date. |
| **EndDate** | DateTime | End date. |
| **MonthsPeriod** | int | Number of months until the next invoice. |
| **NextOccurrenceOn** | DateTime | Next invoice date. |
| **LastDayInMonth** | bool | Issue an invoice on the last day of the month. |
| **TaxDateAtEndOfLastMonth** | bool | Set CED at the end of last month. |
| **Due** | int | Number of days until the invoice is overdue. |
| **SendEmail** | bool | Send invoice by email. |
| **SubjectId** | int | Subject ID. |
| **NumberFormatId** | int | Number format ID. |
| **Note** | string | Text before invoice lines. |
| **FooterNote** | string | Text in invoice footer. |
| **LegacyBankDetails** | [FakturoidLegacyBankDetails](#fakturoidlegacybankdetails-class) | Display IBAN, BIC (SWIFT) and bank account number for legacy generators set without bank account ID. |
| **BankAccountId** | int | Bank account ID. |
| **IbanVisibility** | string | Controls IBAN visibility on the document webinvoice and PDF. IBAN must be valid to show. |
| **Tags** | List\<string\> | List of tags. |
| **OrderNumber** | string | Order number. |
| **Currency** | string | Currency ISO code. |
| **ExchangeRate** | decimal | Exchange rate. |
| **PaymentMethod** | string | Payment method. |
| **CustomPaymentMethod** | string | Custom payment method (payment_method attribute must be set to custom, otherwise the custom_payment_method value is ignored and set to null). |
| **Language** | string | Invoice language. |
| **VatPriceMode** | string | Calculate VAT from base or final amount. |
| **TransferredTaxLiability** | bool | Use reverse charge. |
| **SupplyCode** | int | Supply code for reverse charge. |
| **Oss** | string | Use OSS mode on invoice. |
| **RoundTotal** | bool | Round total amount (VAT included). |
| **Subtotal** | decimal | Total amount without VAT. |
| **Total** | decimal | Total amount with VAT. |
| **NativeSubtotal** | decimal | Total amount without VAT in the account currency. |
| **NativeTotal** | decimal | Total amount with VAT in the account currency. |
| **Lines** | List\<[FakturoidLine](#fakturoidline-class)\> | List of lines to invoice. You can use variables for inserting dates to your text. |
| **HtmlUrl** | string | Generator HTML web address. |
| **Url** | string | Generator API address. |
| **SubjectUrl** | string | API address of subject. |
| **CreatedAt** | DateTimeOffset | Date and time of generator creation. |
| **UpdatedAt** | DateTimeOffset | Date and time of last generator update. |
# FakturoidAccessToken Class

Namespace: Altairis.Fakturoid.Client.Models

Access token

## Properties

| Name | Type | Summary |
|---|---|---|
| **AccessToken** | string | Gets or sets the access token. |
| **TokenType** | string | Gets or sets the type of the token. |
| **ExpiresIn** | int | Gets or sets the expiration time in seconds. |
# FakturoidAccount Class

Namespace: Altairis.Fakturoid.Client.Models

Account data.

## Properties

| Name | Type | Summary |
|---|---|---|
| **Subdomain** | string | Subdomain. |
| **Plan** | string | Subscription plan. |
| **PlanPrice** | int | Price of subscription plan. |
| **PlanPaidUsers** | int | Number of paid users. |
| **InvoiceEmail** | string | Email for sending invoices. |
| **Phone** | string | Phone number. |
| **Web** | string | Account owner's website. |
| **Name** | string | The name of the company. |
| **FullName** | string | Name of the account holder. |
| **RegistrationNo** | string | Registration number. |
| **VatNo** | string | Tax identification number. |
| **LocalVatNo** | string | Tax identification number for SK subject. |
| **VatMode** | string | VAT mode. |
| **VatPriceMode** | string | VAT calculation mode. |
| **Street** | string | Street. |
| **City** | string | City. |
| **Zip** | string | Postal code. |
| **Country** | string | Country (ISO Code). |
| **Currency** | string | Default currency (ISO Code). |
| **UnitName** | string | Default measurement unit. |
| **VatRate** | int | Default VAT rate. |
| **DisplayedNote** | string | Invoice footer. |
| **InvoiceNote** | string | Text before lines. |
| **Due** | int | Default number of days until an invoice becomes overdue. |
| **InvoiceLanguage** | string | Default invoice language. |
| **InvoicePaymentMethod** | string | Default payment method. |
| **InvoiceProforma** | bool | Issue proforma by default. |
| **InvoiceHideBankAccountForPayments** | string[] | Hide bank account for payments. |
| **FixedExchangeRate** | bool | Fixed exchange rate. |
| **InvoiceSelfbilling** | bool | Selfbilling enabled? |
| **DefaultEstimateType** | string | Default estimate in English. |
| **SendOverdueEmail** | bool | Send overdue reminders automatically? |
| **OverdueEmailDays** | int | Days after the due date to send an automatic overdue reminder? |
| **SendRepeatedReminders** | bool | Send automatic overdue reminders repeatedly? |
| **SendInvoiceFromProformaEmail** | bool | Send email automatically when proforma is paid? |
| **SendThankYouEmail** | bool | Send a thank you email when invoices is paid automatically? |
| **InvoicePaypal** | bool | PayPal enabled for all invoices? |
| **InvoiceGopay** | bool | GoPay enabled for all invoices? |
| **DigitooEnabled** | bool | Digitoo service enabled? |
| **DigitooAutoProcessingEnabled** | bool | Digitoo service auto processing enabled. |
| **DigitooExtractionsRemaining** | int | Number of remaining extractions by Digitoo service. |
| **CreatedAt** | DateTimeOffset | Account creation date. |
| **UpdatedAt** | DateTimeOffset | The date the account was last modified. |
# FakturoidAttachment Class

Namespace: Altairis.Fakturoid.Client.Models

Attachment for download

## Properties

| Name | Type | Summary |
|---|---|---|
| **FileName** | string | Attachment file name. |
| **ContentType** | string | Attachment file MIME type. |
| **DownloadUrl** | string | API URL for file download. |
# FakturoidAttachmentUpload Class

Namespace: Altairis.Fakturoid.Client.Models

Attachment.

## Properties

| Name | Type | Summary |
|---|---|---|
| **Filename** | string | Attachment file name. |
| **DataUrl** | string | Attachment contents in the form of a Data URI. |
# FakturoidBankAccount Class

Namespace: Altairis.Fakturoid.Client.Models

Bank account data.

## Properties

| Name | Type | Summary |
|---|---|---|
| **Id** | int | Unique identifier in Fakturoid. |
| **Name** | string | Account name. |
| **Currency** | string | Currency. |
| **Number** | string | Account number. |
| **Iban** | string | IBAN code. |
| **SwiftBic** | string | BIC (for SWIFT payments). |
| **Pairing** | bool | Pairing of incoming payments. |
| **ExpensePairing** | bool | Pairing of outgoing payments. |
| **PaymentAdjustment** | bool | Small amount settlement when matching payments. |
| **Default** | bool | Default bank account. |
| **CreatedAt** | DateTimeOffset | Date and time of bank account creation. |
| **UpdatedAt** | DateTimeOffset | Date and time of last bank account update. |
# FakturoidEvent Class

Namespace: Altairis.Fakturoid.Client.Models

Event data.

## Properties

| Name | Type | Summary |
|---|---|---|
| **Name** | string | Event name |
| **CreatedAt** | DateTimeOffset | Date and time of event creation |
| **Text** | string | Text of the event |
| **RelatedObjects** | List\<[FakturoidRelatedObject](#fakturoidrelatedobject-class)\> | Attributes of objects related to the event |
| **User** | [FakturoidEventUser](#fakturoideventuser-class) | User details |
| **Params** | Object | Parameters with details about event, specific for each type of event |
# FakturoidEventUser Class

Namespace: Altairis.Fakturoid.Client.Models

User related to event

## Properties

| Name | Type | Summary |
|---|---|---|
| **Id** | int | User ID |
| **FullName** | string | Full user name |
| **Avatar** | string | Avatar URL |
# FakturoidExpense Class

Namespace: Altairis.Fakturoid.Client.Models

Expense data.

## Properties

| Name | Type | Summary |
|---|---|---|
| **Id** | int | Unique identifier in Fakturoid. |
| **CustomId** | string | Identifier in your application. |
| **Number** | string | Expense number. Default: Calculate new number automatically. |
| **OriginalNumber** | string | Original expense number. |
| **VariableSymbol** | string | Variable symbol. |
| **SupplierName** | string | Subject company name. |
| **SupplierStreet** | string | Subject address street. |
| **SupplierCity** | string | Subject address city. |
| **SupplierZip** | string | Subject address postal code. |
| **SupplierCountry** | string | Subject address country (ISO Code). |
| **SupplierRegistrationNo** | string | Subject registration number (IČO). |
| **SupplierVatNo** | string | Subject VAT number (DIČ). |
| **SupplierLocalVatNo** | string | Subject SK DIČ (only for Slovakia, does not start with country code). |
| **SubjectId** | int | Subject ID. |
| **Status** | string | Current state of the expense. Values: open, overdue, paid. |
| **DocumentType** | string | Type of expense document. Values: invoice, bill (Receipt), other. Default: invoice. |
| **IssuedOn** | DateTime | Date of issue. |
| **TaxableFulfillmentDue** | DateTime | Chargeable event date. |
| **ReceivedOn** | DateTime | Date when you received the expense from your supplier. |
| **DueOn** | DateTime | Date when the expense becomes overdue. |
| **RemindDueDate** | bool | Remind the upcoming due date with a Todo. Default: true. |
| **PaidOn** | DateTime | Date when the expense was marked as paid. |
| **LockedAt** | DateTime | Date and time when the expense was locked. |
| **Description** | string | Expense description. |
| **PrivateNote** | string | Private note. |
| **Tags** | List\<string\> | List of tags. |
| **BankAccount** | string | Supplier bank account number. Default: Inherit from supplier subject. |
| **Iban** | string | Supplier bank account IBAN. Default: Inherit from supplier subject. |
| **SwiftBic** | string | Supplier bank account BIC (for SWIFT payments). Default: Inherit from supplier subject. |
| **PaymentMethod** | string | Payment method. Values: bank, cash, cod (cash on delivery), card, paypal, custom. Default: bank. |
| **CustomPaymentMethod** | string | Custom payment method (payment_method attribute must be set to custom, otherwise the custom_payment_method value is ignored and set to null). Value: String up to 20 characters. |
| **Currency** | string | Currency ISO Code. Default: Inherit from account settings. |
| **ExchangeRate** | decimal | Exchange rate (required if expense currency differs from account currency). |
| **TransferredTaxLiability** | bool | Self-assesment of VAT? Default: false. |
| **SupplyCode** | string | Supply code for statement about expenses in reverse charge. |
| **VatPriceMode** | string | Calculate VAT from base or final amount. Values: without_vat, from_total_with_vat. Default: without_vat. |
| **ProportionalVatDeduction** | int | Proportional VAT deduction (percent). Default: 100. |
| **TaxDeductible** | bool | Tax deductible. Default: true. |
| **Subtotal** | decimal | Total without VAT. |
| **Total** | decimal | Total with VAT. |
| **NativeSubtotal** | decimal | Total without VAT in the account currency. |
| **NativeTotal** | decimal | Total with VAT in the account currency. |
| **Lines** | List\<[FakturoidLine](#fakturoidline-class)\> | List of lines to expense. |
| **VatRatesSummary** | List\<[FakturoidVatRateSummary](#fakturoidvatratesummary-class)\> | VAT rates summary. |
| **Payments** | List\<[FakturoidExpensePayment](#fakturoidexpensepayment-class)\> | List of payments. |
| **Attachments** | List\<[FakturoidAttachment](#fakturoidattachment-class)\> | List of attachments. |
| **HtmlUrl** | string | Expense HTML web address. |
| **Url** | string | Expense API address. |
| **SubjectUrl** | string | Subject API address. |
| **CreatedAt** | DateTimeOffset | Date and time of expense creation. |
| **UpdatedAt** | DateTimeOffset | Date and time of last expense update. |
# FakturoidExpensePayment Class

Namespace: Altairis.Fakturoid.Client.Models

Expense payment data.

## Properties

| Name | Type | Summary |
|---|---|---|
| **Id** | int | Unique identifier in Fakturoid |
| **PaidOn** | DateTime | Payment date<br>Default: Today |
| **Currency** | string | Currency ISO Code (same as expense currency) |
| **Amount** | decimal | Paid amount in document currency<br>Default: Remaining amount to pay |
| **NativeAmount** | decimal | Paid amount in account currency<br>Default: Remaining amount to pay converted to account currency |
| **MarkDocumentAsPaid** | bool | Mark document as paid?<br>Default: true if the total paid amount becomes greater or equal to remaining amount to pay |
| **VariableSymbol** | string | Payment variable symbol<br>Default: Expense variable symbol |
| **BankAccountId** | int | Bank account ID<br>Default: Expense bank account or default bank account |
| **CreatedAt** | DateTimeOffset | The date and time of payment creation |
| **UpdatedAt** | DateTimeOffset | The date and time of last payment update |
# FakturoidGenerator Class

Namespace: Altairis.Fakturoid.Client.Models

Generator

## Properties

| Name | Type | Summary |
|---|---|---|
| **Id** | int | Unique identifier in Fakturoid |
| **CustomId** | string | Identifier in your application |
| **Name** | string | Template name |
| **Proforma** | bool | Issue invoice as a proforma<br>Default: false |
| **Paypal** | bool | Show PayPal pay button on invoice<br>Default: false |
| **Gopay** | bool | Show GoPay pay button on invoice<br>Default: false |
| **TaxDateAtEndOfLastMonth** | bool | Set CED at the end of last month<br>Default: false |
| **Due** | int | Number of days until the invoice is overdue<br>Default: Inherit from account settings |
| **SubjectId** | int | Subject ID |
| **NumberFormatId** | int | Number format ID<br>Default: Inherit from default account settings |
| **Note** | string | Text before invoice lines |
| **FooterNote** | string | Text in invoice footer |
| **LegacyBankDetails** | Object | Display IBAN, BIC (SWIFT) and bank account number for legacy templates set without bank account ID<br>Default: null |
| **BankAccountId** | int | Bank account ID<br>Default: Inherit from account settings |
| **IbanVisibility** | string | Controls IBAN visibility on the document webinvoice and PDF. IBAN must be valid to show<br>Values: automatically, always<br>Default: automatically |
| **Tags** | List\<string\> | List of tags |
| **OrderNumber** | string | Order number |
| **Currency** | string | Currency ISO code<br>Default: Inherit from account settings |
| **ExchangeRate** | decimal | Exchange rate |
| **PaymentMethod** | string | Payment method<br>Values: bank, cash, cod (cash on delivery), card, paypal, custom<br>Default: Inherit from account settings |
| **CustomPaymentMethod** | string | Custom payment method (payment_method attribute must be set to custom, otherwise the custom_payment_method value is ignored and set to null)<br>Value: String up to 20 characters<br>Default: Inherit from account settings if default account payment method is set to custom |
| **Language** | string | Invoice language<br>Values: cz, sk, en, de, fr, it, es, ru, pl, hu, ro<br>Default: Inherit from account settings |
| **VatPriceMode** | string | Calculate VAT from base or final amount, more info in a table below<br>Values: without_vat, from_total_with_vat<br>Default: Inherit from account settings |
| **TransferredTaxLiability** | bool | Use reverse charge<br>Default: false |
| **SupplyCode** | int | Supply code for reverse charge<br>List of codes |
| **Oss** | string | Use OSS mode on invoice<br>Values: disabled, service, goods<br>Default: disabled |
| **RoundTotal** | bool | Round total amount (VAT included)<br>Default: false |
| **Subtotal** | decimal | Total amount without VAT |
| **Total** | decimal | Total amount with VAT |
| **NativeSubtotal** | decimal | Total amount without VAT in the account currency |
| **NativeTotal** | decimal | Total amount with VAT in the account currency |
| **Lines** | List\<[FakturoidLine](#fakturoidline-class)\> | List of lines to invoice |
| **HtmlUrl** | string | Template HTML web address |
| **Url** | string | Template API address |
| **SubjectUrl** | string | API address of subject |
| **CreatedAt** | DateTimeOffset | Date and time of template creation |
| **UpdatedAt** | DateTimeOffset | Date and time of last template update |
# FakturoidInboxFile Class

Namespace: Altairis.Fakturoid.Client.Models

Inbox file

## Properties

| Name | Type | Summary |
|---|---|---|
| **Id** | int | Unique identifier in Fakturoid |
| **Filename** | string | File name (with extension) |
| **Bytesize** | int | File size in bytes |
| **SendToOcr** | bool | The file will be sent to OCR |
| **SentToOcrAt** | DateTime? | The date and time the file was sent to OCR |
| **OcrStatus** | string | OCR file processing status<br>Values: created, processing, processing_failed, processing_rejected, processed<br>Note: null value is returned when the file is not sent to OCR |
| **OcrCompletedAt** | DateTime? | The date and time the OCR file was completed |
| **DownloadUrl** | string | URL to download the file |
| **CreatedAt** | DateTimeOffset | The date and time of file creation |
| **UpdatedAt** | DateTimeOffset | The date and time of last file update |
# FakturoidInventory Class

Namespace: Altairis.Fakturoid.Client.Models

Inventory information.

## Properties

| Name | Type | Summary |
|---|---|---|
| **ItemId** | int | ID of the related inventory item. |
| **Sku** | string | Stock Keeping Unit (SKU). |
| **ArticleNumberType** | string | Article number type (only if article_number is present).<br>Values: ian, ean, isbn |
| **ArticleNumber** | string | Article number (if present). |
| **MoveId** | int | ID of the related inventory move. |
# FakturoidInventoryItem Class

Namespace: Altairis.Fakturoid.Client.Models

Inventory item data.

## Properties

| Name | Type | Summary |
|---|---|---|
| **Id** | int | Unique identifier in Fakturoid. |
| **Name** | string | Item name. |
| **Sku** | string | Stock Keeping Unit (SKU). Required if track_quantity is enabled. |
| **ArticleNumberType** | string | Article number type. Values: ian, ean, isbn. Default: ian. |
| **ArticleNumber** | string | Article number. |
| **UnitName** | string | Unit of measure. |
| **TrackQuantity** | bool | Track quantity via inventory moves? Default: false. |
| **Quantity** | decimal | Quantity in stock. Required if track_quantity is enabled. Becomes read-only after item creation and can be changed only via inventory moves. |
| **MinQuantity** | decimal | Minimum stock quantity. |
| **MaxQuantity** | decimal | Maximum stock quantity. |
| **AllowBelowZero** | bool | Allow quantity below zero. Default: false. |
| **LowQuantityDate** | DateTime | Date when item quantity dropped below min_quantity. |
| **NativePurchasePrice** | decimal | Unit purchase price without VAT in account currency. Required if track_quantity is enabled. |
| **NativeRetailPrice** | decimal | Unit retail price without VAT in account currency. |
| **VatRate** | string | VAT rate. Values: standard (21%), reduced (15%), reduced2 (10%), zero (0%). |
| **AverageNativePurchasePrice** | decimal | Average purchase price in account currency. |
| **SupplyType** | string | Item type. Values: goods, service. Default: goods. |
| **Archived** | bool | If item is archived. |
| **PrivateNote** | string | Private note. |
| **SuggestFor** | string | Suggest item for documents. Values: invoices, expenses, both. Default: both. |
| **CreatedAt** | DateTimeOffset | Date and time of item creation. |
| **UpdatedAt** | DateTimeOffset | Date and time of last item update. |
# FakturoidInventoryMove Class

Namespace: Altairis.Fakturoid.Client.Models

Inventory move.

## Properties

| Name | Type | Summary |
|---|---|---|
| **Id** | int | Unique identifier in Fakturoid. |
| **Direction** | string | Move direction. Values: in, out. |
| **MovedOn** | DateTime | Move date. |
| **QuantityChange** | decimal | Item quantity in move. |
| **PurchasePrice** | decimal | Purchase price per unit (without VAT). |
| **PurchaseCurrency** | string | Purchase currency. Values: Currency code (3 characters). Default: Inherit from account settings. |
| **NativePurchasePrice** | decimal | Unit purchase price in account currency. |
| **RetailPrice** | decimal | Retail price per unit. |
| **RetailCurrency** | string | Retail currency. Values: Currency code (3 characters). Default: Inherit from account settings. |
| **NativeRetailPrice** | decimal | Retail price in account currency. |
| **PrivateNote** | string | Private note. |
| **InventoryItemId** | int | Inventory item ID. |
| **Document** | Object | Details about document and line the move is tied to. Default: null. |
| **CreatedAt** | DateTimeOffset | Date and time of move creation. |
| **UpdatedAt** | DateTimeOffset | Date and time of last move update. |
# FakturoidInventoryMoveDocument Class

Namespace: Altairis.Fakturoid.Client.Models

Document related to inventory move.

## Properties

| Name | Type | Summary |
|---|---|---|
| **Id** | int | Gets or sets the document ID. |
| **Type** | string | Gets or sets the type of document.<br>Values: Estimate, Expense, ExpenseGenerator, Generator, Invoice |
| **LineId** | int | Gets or sets the document line ID. |
# FakturoidInvoice Class

Namespace: Altairis.Fakturoid.Client.Models

Invoice data.

## Properties

| Name | Type | Summary |
|---|---|---|
| **Id** | int | Unique identifier in Fakturoid. |
| **CustomId** | string | Identifier in your application. |
| **DocumentType** | string | Type of document.<br>Values: partial_proforma, proforma, correction, tax_document, final_invoice, invoice |
| **ProformaFollowupDocument** | string | What to issue after a proforma is paid.<br>Values: final_invoice_paid, final_invoice, tax_document, none |
| **TaxDocumentIds** | List\<int\> | Required only when creating a final invoice from tax documents. |
| **CorrectionId** | int | ID of the invoice being corrected. |
| **Number** | string | Document number. |
| **NumberFormatId** | int | ID of a number format. |
| **VariableSymbol** | string | Variable symbol. |
| **YourName** | string | Name of your company. |
| **YourStreet** | string | Your address street. |
| **YourCity** | string | Your address city. |
| **YourZip** | string | Your address postal code. |
| **YourCountry** | string | Your address country (ISO code). |
| **YourRegistrationNo** | string | Your registration number (IČO). |
| **YourVatNo** | string | Your VAT number (DIČ). |
| **YourLocalVatNo** | string | Your SK DIČ (only for Slovakia, does not start with country code). |
| **ClientName** | string | Subject company name. |
| **ClientStreet** | string | Subject address street. |
| **ClientCity** | string | Subject address city. |
| **ClientZip** | string | Subject address postal code. |
| **ClientCountry** | string | Subject address country (ISO code). |
| **ClientHasDeliveryAddress** | bool | Enable delivery address. |
| **ClientDeliveryName** | string | Subject company delivery name. |
| **ClientDeliveryStreet** | string | Subject delivery address street. |
| **ClientDeliveryCity** | string | Subject delivery address city. |
| **ClientDeliveryZip** | string | Subject delivery address postal code. |
| **ClientDeliveryCountry** | string | Subject delivery address country (ISO code). |
| **ClientRegistrationNo** | string | Subject registration number. |
| **ClientVatNo** | string | Subject VAT number. |
| **ClientLocalVatNo** | string | Subject SK DIČ (only for Slovakia, does not start with country code). |
| **SubjectId** | int | Subject ID. |
| **SubjectCustomId** | string | Subject identifier in your application. |
| **GeneratorId** | int | Generator ID from which the document was generated. |
| **RelatedId** | int | ID of related document. |
| **Paypal** | bool | Enable PayPal payment button on invoice. |
| **Gopay** | bool | Enable GoPay payment button on invoice. |
| **Token** | string | Token string for the webinvoice URL. |
| **Status** | string | Current state of the document.<br>Values: open, sent, overdue, paid, cancelled, uncollectible |
| **OrderNumber** | string | Order number in your application. |
| **IssuedOn** | DateTime | Date of issue. |
| **TaxableFulfillmentDue** | string | Chargeable event date. |
| **Due** | int | Number of days until the invoice becomes overdue. |
| **DueOn** | DateTime | Date when the invoice becomes overdue. |
| **SentAt** | DateTime | Date and time of sending the document via email. |
| **PaidOn** | DateTime | Date when the document was marked as paid. |
| **ReminderSentAt** | DateTime | Date and time of sending a reminder. |
| **CancelledAt** | DateTime | Date and time when the invoice was cancelled (only for non-VAT-payers). |
| **UncollectibleAt** | DateTime | Date and time when an invoice was marked as uncollectible. |
| **LockedAt** | DateTime | Date and time when the document was locked. |
| **WebinvoiceSeenOn** | DateTime | Date when the client visited the webinvoice. |
| **Note** | string | Text before lines. |
| **FooterNote** | string | Invoice footer. |
| **PrivateNote** | string | Private note. |
| **Tags** | List\<string\> | List of tags. |
| **BankAccountId** | int | Bank account ID (used only on create action). |
| **BankAccount** | string | Bank account number. |
| **Iban** | string | IBAN. |
| **SwiftBic** | string | BIC (for SWIFT payments). |
| **IbanVisibility** | string | Controls IBAN visibility on the document webinvoice and PDF.<br>Values: automatically, always |
| **ShowAlreadyPaidNoteInPdf** | bool | Show „Do not pay, …“ on document webinvoice and PDF. |
| **PaymentMethod** | string | Payment method.<br>Values: bank, cash, cod, card, paypal, custom |
| **CustomPaymentMethod** | string | Custom payment method. |
| **HideBankAccount** | bool | Hide bank account on webinvoice and PDF. |
| **Currency** | string | Currency ISO code. |
| **ExchangeRate** | decimal | Exchange rate (required if document currency differs from account currency). |
| **Language** | string | Language of the document.<br>Values: cz, sk, en, de, fr, it, es, ru, pl, hu, ro |
| **TransferredTaxLiability** | bool | Use reverse charge. |
| **SupplyCode** | string | Supply code for statement about invoices in reverse charge. |
| **Oss** | string | Use OSS mode.<br>Values: disabled, service, goods |
| **VatPriceMode** | string | Calculate VAT from base or final amount.<br>Values: without_vat, from_total_with_vat |
| **RoundTotal** | bool | Round total amount (VAT included). |
| **Subtotal** | decimal | Total without VAT. |
| **Total** | decimal | Total with VAT. |
| **NativeSubtotal** | decimal | Total without VAT in the account currency. |
| **NativeTotal** | decimal | Total with VAT in the account currency. |
| **RemainingAmount** | decimal | Remaining amount to pay (VAT included). |
| **RemainingNativeAmount** | decimal | Remaining amount to pay in the account currency (VAT included). |
| **Lines** | List\<[FakturoidLine](#fakturoidline-class)\> | List of lines to invoice. |
| **VatRatesSummary** | List\<[FakturoidVatRateSummary](#fakturoidvatratesummary-class)\> | VAT rates summary. |
| **PaidAdvances** | List\<[FakturoidInvoicePaidAdvance](#fakturoidinvoicepaidadvance-class)\> | List of paid advances (if final invoice). |
| **Payments** | List\<[FakturoidInvoicePayment](#fakturoidinvoicepayment-class)\> | List of payments. |
| **Attachments** | List\<[FakturoidAttachment](#fakturoidattachment-class)\> | List of attachments. |
| **HtmlUrl** | string | Document HTML web address. |
| **PublicHtmlUrl** | string | Webinvoice web address. |
| **Url** | string | Document API address. |
| **PdfUrl** | string | PDF download address. |
| **SubjectUrl** | string | Subject API address. |
| **CreatedAt** | DateTimeOffset | Date and time of document creation. |
| **UpdatedAt** | DateTimeOffset | Date and time of last document update. |
# FakturoidInvoiceMessage Class

Namespace: Altairis.Fakturoid.Client.Models

Invoice message

## Properties

| Name | Type | Summary |
|---|---|---|
| **Subject** | string | Email subject<br>Default: Inherit from account settings |
| **Email** | string | Email address<br>Default: Inherit from invoice subject |
| **EmailCopy** | string | Email copy address<br>Default: Inherit from invoice subject |
| **Message** | string | Email message<br>Default: Inherit from account settings |
| **DeliverNow** | bool | Deliver e-mail immediately if you are outside of the delivery times set in settings<br>Default: false<br>This option has effect only if you have set e-mail delivery window in Fakturoid settings and you are outside of the given times. If the delivery times are not set or you are in the given window e-mail are always sent immediately. |
# FakturoidInvoicePaidAdvance Class

Namespace: Altairis.Fakturoid.Client.Models

Paid advance

## Properties

| Name | Type | Summary |
|---|---|---|
| **Id** | int | Tax document ID. |
| **Number** | string | Document number. |
| **VariableSymbol** | string | Variable symbol. |
| **PaidOn** | DateTime | Date of payment. |
| **VatRate** | decimal | VAT rate. |
| **Price** | decimal | Price for given VAT rate. |
| **Vat** | decimal | VAT for given VAT rate. |
# FakturoidInvoicePayment Class

Namespace: Altairis.Fakturoid.Client.Models

Invoice payment data.

## Properties

| Name | Type | Summary |
|---|---|---|
| **Id** | int | Unique identifier in Fakturoid. |
| **PaidOn** | DateTime | Payment date.<br>Default: Today |
| **Currency** | string | Currency ISO Code (same as invoice currency). |
| **Amount** | decimal | Paid amount in document currency.<br>Default: Remaining amount to pay |
| **NativeAmount** | decimal | Paid amount in account currency.<br>Default: Remaining amount to pay converted to account currency |
| **MarkDocumentAsPaid** | bool | Mark document as paid?<br>Default: true if the total paid amount becomes greater or equal to remaining amount to pay |
| **ProformaFollowupDocument** | string | Issue a followup document with payment.<br>Only for proformas and mark_document_as_paid must be true.<br>Values: final_invoice_paid, final_invoice, tax_document, none |
| **SendThankYouEmail** | bool | Send thank-you email?<br>mark_document_as_paid must be true<br>Default: Inherit from account settings |
| **VariableSymbol** | string | Payment variable symbol.<br>Default: Invoice variable symbol |
| **BankAccountId** | int | Bank account ID.<br>Default: Invoice bank account or default bank account |
| **TaxDocumentId** | int | Tax document ID (if present). |
| **CreatedAt** | DateTimeOffset | The date and time of payment creation. |
| **UpdatedAt** | DateTimeOffset | The date and time of last payment update. |
# FakturoidLegacyBankDetails Class

Namespace: Altairis.Fakturoid.Client.Models

Legacy bank account details

## Properties

| Name | Type | Summary |
|---|---|---|
| **BankAccount** | string | Bank account number |
| **Iban** | string | IBAN |
| **SwiftBic** | string | BIC (for SWIFT payments) |
# FakturoidLine Class

Namespace: Altairis.Fakturoid.Client.Models

Invoice line.

## Properties

| Name | Type | Summary |
|---|---|---|
| **Id** | int | Unique identifier in Fakturoid. |
| **Name** | string | Line name. |
| **Quantity** | decimal | Quantity. |
| **UnitName** | string | Unit name. |
| **UnitPrice** | decimal | Unit price. |
| **VatRate** | decimal | VAT rate. |
| **UnitPriceWithoutVat** | decimal | Unit price without VAT. |
| **UnitPriceWithVat** | decimal | Unit price including VAT. |
| **TotalPriceWithoutVat** | decimal | Total price without VAT. |
| **TotalVat** | decimal | Total VAT. |
| **NativeTotalPriceWithoutVat** | decimal | Total price without VAT in account currency. |
| **NativeTotalVat** | decimal | Total VAT in account currency. |
| **InventoryItemId** | int | ID of the related inventory item. |
| **Sku** | string | Stock Keeping Unit (SKU). |
| **Inventory** | [FakturoidInventory](#fakturoidinventory-class) | Inventory information. |
# FakturoidNumberFormat Class

Namespace: Altairis.Fakturoid.Client.Models

Invoice number format.

## Properties

| Name | Type | Summary |
|---|---|---|
| **Id** | int | Unique identifier in Fakturoid. |
| **Format** | string | Format. |
| **Preview** | string | Preview of number format. |
| **Default** | bool | Default number format. |
| **CreatedAt** | DateTimeOffset | Date and time of number format creation. |
| **UpdatedAt** | DateTimeOffset | Date and time of last number format update. |
# FakturoidRelatedObject Class

Namespace: Altairis.Fakturoid.Client.Models

Represents an object related to the event.

## Properties

| Name | Type | Summary |
|---|---|---|
| **Type** | string | Type of the object related to the event<br>Values: Invoice, Subject, Expense, Generator, RecurringGenerator, ExpenseGenerator, Estimate |
| **Id** | int | ID of the object related to event |
# FakturoidSubject Class

Namespace: Altairis.Fakturoid.Client.Models

Subject (contact).

## Properties

| Name | Type | Summary |
|---|---|---|
| **Id** | int | Unique identifier in Fakturoid |
| **CustomId** | string | Identifier in your application |
| **UserId** | int | User ID who created the subject |
| **Type** | string | Type of subject. Values: "customer", "supplier", "both". Default: "customer" |
| **Name** | string | Name of the subject |
| **FullName** | string | Contact person name |
| **Email** | string | Main email address to receive invoice emails |
| **EmailCopy** | string | Email copy address to receive invoice emails |
| **Phone** | string | Phone number |
| **Web** | string | Web page |
| **Street** | string | Street |
| **City** | string | City |
| **Zip** | string | ZIP or postal code |
| **Country** | string | Country (ISO code). Default: Account setting |
| **HasDeliveryAddress** | bool | Enable delivery address. Default: false |
| **DeliveryName** | string | Delivery address name |
| **DeliveryStreet** | string | Delivery address street |
| **DeliveryCity** | string | Delivery address city |
| **DeliveryZip** | string | Delivery address ZIP or postal code |
| **DeliveryCountry** | string | Delivery address country (ISO code). Default: Account setting |
| **Due** | int? | Number of days until an invoice is due for this subject. Default: Inherit from account settings |
| **Currency** | string | Currency (ISO code). Default: Inherit from account settings |
| **Language** | string | Invoice language. Default: Inherit from account settings |
| **PrivateNote** | string | Private note |
| **RegistrationNo** | string | Registration number (IČO) |
| **VatNo** | string | VAT-payer VAT number (DIČ, IČ DPH in Slovakia, typically starts with the country code) |
| **LocalVatNo** | string | SK DIČ (only in Slovakia, does not start with country code) |
| **Unreliable** | bool | Unreliable VAT-payer |
| **UnreliableCheckedAt** | DateTime? | Date of last check for unreliable VAT-payer |
| **LegalForm** | string | Legal form |
| **VatMode** | string | VAT mode |
| **BankAccount** | string | Bank account number |
| **Iban** | string | IBAN |
| **SwiftBic** | string | SWIFT/BIC |
| **VariableSymbol** | string | Fixed variable symbol (used for all invoices for this client instead of invoice number) |
| **SettingUpdateFromAres** | string | Whether to update subject data from ARES. Used to override account settings. Values: inherit, on, off. Default: inherit |
| **AresUpdate** | bool | Whether to update subject data from ARES. Used to override account settings. Default: true. Deprecated in favor of setting_update_from_ares |
| **SettingInvoicePdfAttachments** | string | Whether to attach invoice PDF in email. Used to override account settings. Values: inherit, on, off. Default: inherit |
| **SettingEstimatePdfAttachments** | string | Whether to attach estimate PDF in email. Used to override account settings. Values: inherit, on, off. Default: inherit |
| **SettingInvoiceSendReminders** | string | Whether to send overdue invoice email reminders. Used to override account settings. Values: inherit, on, off. Default: inherit |
| **SuggestionEnabled** | bool | Suggest for documents. Default: true |
| **CustomEmailText** | string | New invoice custom email text |
| **OverdueEmailText** | string | Overdue reminder custom email text |
| **InvoiceFromProformaEmailText** | string | Proforma paid custom email text |
| **ThankYouEmailText** | string | Thanks for payment custom email text |
| **CustomEstimateEmailText** | string | Estimate custom email text |
| **WebinvoiceHistory** | string | Webinvoice history. Values: null, "disabled", "recent", "client_portal". Default: null (inherit from account settings) |
| **HtmlUrl** | string | Subject HTML web address |
| **Url** | string | Subject API address |
| **CreatedAt** | DateTimeOffset | Date and time of subject creation |
| **UpdatedAt** | DateTimeOffset | Date and time of last subject update |
# FakturoidTodo Class

Namespace: Altairis.Fakturoid.Client.Models

Todo task.

## Properties

| Name | Type | Summary |
|---|---|---|
| **Id** | int | Unique identifier in Fakturoid. |
| **Name** | string | Todo name. |
| **CreatedAt** | DateTimeOffset | Date and time of todo creation. |
| **CompletedAt** | DateTime? | Date and time of todo completion. |
| **Text** | string | Todo text. |
| **RelatedObjects** | List\<[FakturoidRelatedObject](#fakturoidrelatedobject-class)\> | Attributes of objects related to the todo. |
| **Params** | Object | Parameters with details about todo, specific for each type of todo. |
# FakturoidUser Class

Namespace: Altairis.Fakturoid.Client.Models

User

## Properties

| Name | Type | Summary |
|---|---|---|
| **Id** | int | Unique identifier in Fakturoid |
| **FullName** | string | User full name |
| **Email** | string | User email |
| **AvatarUrl** | string | User avatar URL |
| **DefaultAccount** | string | Default account slug (Only on the /user.json endpoint) |
| **Permission** | string | User permission for the current account |
| **AllowedScope** | List\<string\> | List of allowed scopes. Values: reports, expenses, invoices |
| **Accounts** | List\<[FakturoidUserAccount](#fakturoiduseraccount-class)\> | List of accounts the user has access to (Only on the /user.json endpoint) |
# FakturoidUserAccount Class

Namespace: Altairis.Fakturoid.Client.Models

User account information.

## Properties

| Name | Type | Summary |
|---|---|---|
| **Slug** | string | Account URL slug.<br>Goes to https://app.fakturoid.cz/api/v3/accounts/{slug}/… |
| **Logo** | string | Account logo URL. |
| **Name** | string | Account name. |
| **RegistrationNo** | string | Account registration number. |
| **Permission** | string | Current user account permission. |
| **AllowedScope** | string[] | List of allowed scopes for current user.<br>Values: reports, expenses, invoices |
# FakturoidVatRateSummary Class

Namespace: Altairis.Fakturoid.Client.Models

VAT rate summary.

## Properties

| Name | Type | Summary |
|---|---|---|
| **VatRate** | decimal | VAT rate. |
| **Base** | decimal | Base total. |
| **Vat** | decimal | VAT total. |
| **Currency** | string | Currency. |
| **NativeBase** | decimal | Base total in account currency. |
| **NativeVat** | decimal | VAT total in account currency. |
| **NativeCurrency** | string | Account currency. |
# FakturoidWebhook Class

Namespace: Altairis.Fakturoid.Client.Models

Webhook

## Properties

| Name | Type | Summary |
|---|---|---|
| **Id** | int | Unique identifier in Fakturoid |
| **WebhookUrl** | string | URL of webhook endpoint |
| **AuthHeader** | string | Value send in Authorization header |
| **Active** | bool | Send webhook? |
| **Events** | List\<string\> | List of events when webhook is fired |
| **Url** | string | Webhook API address |
| **CreatedAt** | DateTimeOffset | Date and time of webhook creation |
| **UpdatedAt** | DateTimeOffset | Date and time of last webhook update |
# ExpensePaymentStatus Enum

Namespace: Altairis.Fakturoid.Client.Proxies

Expense payment status

## Values

| Name | Summary |
|---|---|
| **Unpaid** | Reset payment status to unpaid. |
| **Paid** | Set status of regular expense to paid. |
# ExpenseStatusCondition Enum

Namespace: Altairis.Fakturoid.Client.Proxies

Query status condition for listing expenses

## Values

| Name | Summary |
|---|---|
| **Any** | Any |
| **Open** | Náklad není zaplacen, odeslán ani po splatnosti. |
| **Overdue** | Náklad je po splatnosti. |
| **Paid** | Náklad je zaplacen. |
# FakturoidBankAccountsProxy Class

Namespace: Altairis.Fakturoid.Client.Proxies

Base class: [FakturoidEntityProxy](#fakturoidentityproxy-class)

Proxy class form working with bank accounts

## Properties

| Name | Type | Summary |
|---|---|---|
| **Context** | [FakturoidContext](#fakturoidcontext-class) | Gets the related context. |
## Methods

| Name | Returns | Summary |
|---|---|---|
| [**SelectAsync()**](#selectasync) | Task\<IEnumerable\<[FakturoidBankAccount](#fakturoidbankaccount-class)\>\> | Gets asynchronously list of all bank accounts. |
## Methods

### SelectAsync()

Gets asynchronously list of all bank accounts.



### Returns

Task<IEnumerable<[FakturoidBankAccount](#fakturoidbankaccount-class)>>

List of **Altairis.Fakturoid.Client.Models.FakturoidBankAccount** instances.

# FakturoidEntityProxy Class

Namespace: Altairis.Fakturoid.Client.Proxies

Proxy class for working with any Fakturoid entity

## Properties

| Name | Type | Summary |
|---|---|---|
| **Context** | [FakturoidContext](#fakturoidcontext-class) | Gets the related context. |
# FakturoidEventsProxy Class

Namespace: Altairis.Fakturoid.Client.Proxies

Base class: [FakturoidEntityProxy](#fakturoidentityproxy-class)

Proxy class for working with events

## Properties

| Name | Type | Summary |
|---|---|---|
| **Context** | [FakturoidContext](#fakturoidcontext-class) | Gets the related context. |
## Methods

| Name | Returns | Summary |
|---|---|---|
| [**SelectAsync(DateTime? since, int? subjectId)**](#selectasyncdatetime-since-int-subjectid) | Task\<IEnumerable\<[FakturoidEvent](#fakturoidevent-class)\>\> | Gets asynchronously list of all current events. |
| [**SelectAsync(int page, DateTime? since)**](#selectasyncint-page-datetime-since) | Task\<IEnumerable\<[FakturoidEvent](#fakturoidevent-class)\>\> | Gets asynchronously list of current events, paged by 40. |
## Methods

### SelectAsync(DateTime? since, int? subjectId)

Gets asynchronously list of all current events.

| Parameter | Type | Description |
|---|---|---|
| since | DateTime? | The date since when events are to be selected. |
| subjectId | int? | The ID of the subject to filter events by. |


### Returns

Task<IEnumerable<[FakturoidEvent](#fakturoidevent-class)>>

List of **Altairis.Fakturoid.Client.Models.FakturoidEvent** instances.

### SelectAsync(int page, DateTime? since)

Gets asynchronously list of current events, paged by 40.

| Parameter | Type | Description |
|---|---|---|
| page | int | The page number. |
| since | DateTime? | The date since when events are to be selected. |


### Returns

Task<IEnumerable<[FakturoidEvent](#fakturoidevent-class)>>

List of **Altairis.Fakturoid.Client.Models.FakturoidEvent** instances.

# FakturoidExpensesProxy Class

Namespace: Altairis.Fakturoid.Client.Proxies

Base class: [FakturoidEntityProxy](#fakturoidentityproxy-class)

Proxy class for working with invoices.

## Properties

| Name | Type | Summary |
|---|---|---|
| **Context** | [FakturoidContext](#fakturoidcontext-class) | Gets the related context. |
## Methods

| Name | Returns | Summary |
|---|---|---|
| [**CreateAsync(FakturoidExpense entity)**](#createasyncfakturoidexpense-entity) | Task\<int\> | Creates asynchronously the specified new expense. |
| [**DeleteAsync(int id)**](#deleteasyncint-id) | Task | Deletes asynchronously expense with specified id. |
| [**SelectAsync(ExpenseStatusCondition status, int? subjectId, DateTime? since, string number)**](#selectasyncexpensestatuscondition-status-int-subjectid-datetime-since-string-number) | Task\<IEnumerable\<[FakturoidExpense](#fakturoidexpense-class)\>\> | Gets asynchronously list of all invoices. |
| [**SelectAsync(int page, ExpenseStatusCondition status, int? subjectId, DateTime? since, string number)**](#selectasyncint-page-expensestatuscondition-status-int-subjectid-datetime-since-string-number) | Task\<IEnumerable\<[FakturoidExpense](#fakturoidexpense-class)\>\> | Gets asynchronously paged list of invoices. |
| [**SelectSingleAsync(int id)**](#selectsingleasyncint-id) | Task\<[FakturoidExpense](#fakturoidexpense-class)\> | Selects asynchronously single expense with specified ID. |
| [**SetAttachmentAsync(int id, string filePath)**](#setattachmentasyncint-id-string-filepath) | Task | Sets attachment for invoice. |
| [**SetAttachmentAsync(int id, string mimeType, byte[] fileContent)**](#setattachmentasyncint-id-string-mimetype-byte-filecontent) | Task | Sets attachment for invoice. |
| [**SetPaymentStatusAsync(int id, ExpensePaymentStatus status)**](#setpaymentstatusasyncint-id-expensepaymentstatus-status) | Task | Sets asynchronously the expense payment status. |
| [**SetPaymentStatusAsync(int id, ExpensePaymentStatus status, DateTime effectiveDate)**](#setpaymentstatusasyncint-id-expensepaymentstatus-status-datetime-effectivedate) | Task | Sets asynchronously the expense payment status. |
| [**UpdateAsync(FakturoidExpense entity)**](#updateasyncfakturoidexpense-entity) | Task\<[FakturoidExpense](#fakturoidexpense-class)\> | Updates asynchronously the specified expense. |
## Methods

### CreateAsync(FakturoidExpense entity)

Creates asynchronously the specified new expense.

| Parameter | Type | Description |
|---|---|---|
| entity | [FakturoidExpense](#fakturoidexpense-class) | The new expense. |


### Returns

Task<int>

ID of newly created expense.

### DeleteAsync(int id)

Deletes asynchronously expense with specified id.

| Parameter | Type | Description |
|---|---|---|
| id | int | The contact id. |


### Returns

Task



### SelectAsync(ExpenseStatusCondition status, int? subjectId, DateTime? since, string number)

Gets asynchronously list of all invoices.

| Parameter | Type | Description |
|---|---|---|
| status | [ExpenseStatusCondition](#expensestatuscondition-enum) | The expense status. |
| subjectId | int? | The customer subject id. |
| since | DateTime? | The date since when the expense was created. |
| number | string | The expense display number. |


### Returns

Task<IEnumerable<[FakturoidExpense](#fakturoidexpense-class)>>

List of **Altairis.Fakturoid.Client.Models.FakturoidExpense** instances.

### SelectAsync(int page, ExpenseStatusCondition status, int? subjectId, DateTime? since, string number)

Gets asynchronously paged list of invoices.

| Parameter | Type | Description |
|---|---|---|
| page | int | The page number. |
| status | [ExpenseStatusCondition](#expensestatuscondition-enum) | The expense status. |
| subjectId | int? | The customer subject id. |
| since | DateTime? | The date since when the expense was created. |
| number | string | The expense display number. |


### Returns

Task<IEnumerable<[FakturoidExpense](#fakturoidexpense-class)>>

List of **Altairis.Fakturoid.Client.Models.FakturoidExpense** instances.

### SelectSingleAsync(int id)

Selects asynchronously single expense with specified ID.

| Parameter | Type | Description |
|---|---|---|
| id | int | The expense id. |


### Returns

Task<[FakturoidExpense](#fakturoidexpense-class)>

Instance of **Altairis.Fakturoid.Client.Models.FakturoidExpense** class.

### SetAttachmentAsync(int id, string filePath)

Sets attachment for invoice.

| Parameter | Type | Description |
|---|---|---|
| id | int | The invoice id. |
| filePath | string | The file path. |


### Returns

Task



### SetAttachmentAsync(int id, string mimeType, byte[] fileContent)

Sets attachment for invoice.

| Parameter | Type | Description |
|---|---|---|
| id | int | The invoice id. |
| mimeType | string | The mime type. |
| fileContent | byte[] | The content of the file. |


### Returns

Task



### SetPaymentStatusAsync(int id, ExpensePaymentStatus status)

Sets asynchronously the expense payment status.

| Parameter | Type | Description |
|---|---|---|
| id | int | The expense id. |
| status | [ExpensePaymentStatus](#expensepaymentstatus-enum) | The new payment status. |


### Returns

Task

Instance of **Altairis.Fakturoid.Client.Models.FakturoidExpense** class with modified entity.

### SetPaymentStatusAsync(int id, ExpensePaymentStatus status, DateTime effectiveDate)

Sets asynchronously the expense payment status.

| Parameter | Type | Description |
|---|---|---|
| id | int | The expense id. |
| status | [ExpensePaymentStatus](#expensepaymentstatus-enum) | The new payment status. |
| effectiveDate | DateTime | The date when payment was performed. |


### Returns

Task



### UpdateAsync(FakturoidExpense entity)

Updates asynchronously the specified expense.

| Parameter | Type | Description |
|---|---|---|
| entity | [FakturoidExpense](#fakturoidexpense-class) | The expense to update. |


### Returns

Task<[FakturoidExpense](#fakturoidexpense-class)>

Instance of **Altairis.Fakturoid.Client.Models.FakturoidExpense** class with modified entity.

# FakturoidInvoicesProxy Class

Namespace: Altairis.Fakturoid.Client.Proxies

Base class: [FakturoidEntityProxy](#fakturoidentityproxy-class)

Proxy class for working with invoices.

## Properties

| Name | Type | Summary |
|---|---|---|
| **Context** | [FakturoidContext](#fakturoidcontext-class) | Gets the related context. |
## Methods

| Name | Returns | Summary |
|---|---|---|
| [**CreateAsync(FakturoidInvoice entity)**](#createasyncfakturoidinvoice-entity) | Task\<int\> | Creates asynchronously the specified new invoice. |
| [**DeleteAsync(int id)**](#deleteasyncint-id) | Task | Deletes asynchronously invoice with specified id. |
| [**SelectAsync(InvoiceTypeCondition type, InvoiceStatusCondition status, int? subjectId, DateTime? since, string number)**](#selectasyncinvoicetypecondition-type-invoicestatuscondition-status-int-subjectid-datetime-since-string-number) | Task\<IEnumerable\<[FakturoidInvoice](#fakturoidinvoice-class)\>\> | Gets asynchronously list of all invoices. |
| [**SelectAsync(int page, InvoiceTypeCondition type, InvoiceStatusCondition status, int? subjectId, DateTime? since, string number)**](#selectasyncint-page-invoicetypecondition-type-invoicestatuscondition-status-int-subjectid-datetime-since-string-number) | Task\<IEnumerable\<[FakturoidInvoice](#fakturoidinvoice-class)\>\> | Gets asynchronously paged list of invoices. |
| [**SelectSingleAsync(int id)**](#selectsingleasyncint-id) | Task\<[FakturoidInvoice](#fakturoidinvoice-class)\> | Selects asynchronously single invoice with specified ID. |
| [**SendMessageAsync(int id, InvoiceMessageType messageType)**](#sendmessageasyncint-id-invoicemessagetype-messagetype) | Task | Sends asynchronously e-mail message for the specified invoice. |
| [**SetAttachmentAsync(int id, string filePath)**](#setattachmentasyncint-id-string-filepath) | Task | Sets attachment for invoice. |
| [**SetAttachmentAsync(int id, string mimeType, byte[] fileContent)**](#setattachmentasyncint-id-string-mimetype-byte-filecontent) | Task | Sets attachment for invoice. |
| [**SetPaymentStatusAsync(int id, InvoicePaymentStatus status)**](#setpaymentstatusasyncint-id-invoicepaymentstatus-status) | Task | Sets asynchronously the invoice payment status. |
| [**SetPaymentStatusAsync(int id, InvoicePaymentStatus status, DateTime effectiveDate)**](#setpaymentstatusasyncint-id-invoicepaymentstatus-status-datetime-effectivedate) | Task | Sets asynchronously the invoice payment status. |
| [**UpdateAsync(FakturoidInvoice entity)**](#updateasyncfakturoidinvoice-entity) | Task\<[FakturoidInvoice](#fakturoidinvoice-class)\> | Updates asynchronously the specified invoice. |
## Methods

### CreateAsync(FakturoidInvoice entity)

Creates asynchronously the specified new invoice.

| Parameter | Type | Description |
|---|---|---|
| entity | [FakturoidInvoice](#fakturoidinvoice-class) | The new invoice. |


### Returns

Task<int>

ID of newly created invoice.

### DeleteAsync(int id)

Deletes asynchronously invoice with specified id.

| Parameter | Type | Description |
|---|---|---|
| id | int | The contact id. |


### Returns

Task



### SelectAsync(InvoiceTypeCondition type, InvoiceStatusCondition status, int? subjectId, DateTime? since, string number)

Gets asynchronously list of all invoices.

| Parameter | Type | Description |
|---|---|---|
| type | [InvoiceTypeCondition](#invoicetypecondition-enum) | The invoice type. |
| status | [InvoiceStatusCondition](#invoicestatuscondition-enum) | The invoice status. |
| subjectId | int? | The customer subject id. |
| since | DateTime? | The date since when the invoice was created. |
| number | string | The invoice display number. |


### Returns

Task<IEnumerable<[FakturoidInvoice](#fakturoidinvoice-class)>>

List of **Altairis.Fakturoid.Client.Models.FakturoidInvoice** instances.

### SelectAsync(int page, InvoiceTypeCondition type, InvoiceStatusCondition status, int? subjectId, DateTime? since, string number)

Gets asynchronously paged list of invoices.

| Parameter | Type | Description |
|---|---|---|
| page | int | The page number. |
| type | [InvoiceTypeCondition](#invoicetypecondition-enum) | The invoice type. |
| status | [InvoiceStatusCondition](#invoicestatuscondition-enum) | The invoice status. |
| subjectId | int? | The customer subject id. |
| since | DateTime? | The date since when the invoice was created. |
| number | string | The invoice display number. |


### Returns

Task<IEnumerable<[FakturoidInvoice](#fakturoidinvoice-class)>>

List of **Altairis.Fakturoid.Client.Models.FakturoidInvoice** instances.

### SelectSingleAsync(int id)

Selects asynchronously single invoice with specified ID.

| Parameter | Type | Description |
|---|---|---|
| id | int | The invoice id. |


### Returns

Task<[FakturoidInvoice](#fakturoidinvoice-class)>

Instance of **Altairis.Fakturoid.Client.Models.FakturoidInvoice** class.

### SendMessageAsync(int id, InvoiceMessageType messageType)

Sends asynchronously e-mail message for the specified invoice.

| Parameter | Type | Description |
|---|---|---|
| id | int | The invoice id. |
| messageType | [InvoiceMessageType](#invoicemessagetype-enum) | Type of the message. |


### Returns

Task



### SetAttachmentAsync(int id, string filePath)

Sets attachment for invoice.

| Parameter | Type | Description |
|---|---|---|
| id | int | The invoice id. |
| filePath | string | The file path. |


### Returns

Task



### SetAttachmentAsync(int id, string mimeType, byte[] fileContent)

Sets attachment for invoice.

| Parameter | Type | Description |
|---|---|---|
| id | int | The invoice id. |
| mimeType | string | The mime type. |
| fileContent | byte[] | The content of the file. |


### Returns

Task



### SetPaymentStatusAsync(int id, InvoicePaymentStatus status)

Sets asynchronously the invoice payment status.

| Parameter | Type | Description |
|---|---|---|
| id | int | The invoice id. |
| status | [InvoicePaymentStatus](#invoicepaymentstatus-enum) | The new payment status. |


### Returns

Task

Instance of **Altairis.Fakturoid.Client.Models.FakturoidInvoice** class with modified entity.

### SetPaymentStatusAsync(int id, InvoicePaymentStatus status, DateTime effectiveDate)

Sets asynchronously the invoice payment status.

| Parameter | Type | Description |
|---|---|---|
| id | int | The invoice id. |
| status | [InvoicePaymentStatus](#invoicepaymentstatus-enum) | The new payment status. |
| effectiveDate | DateTime | The date when payment was performed. |


### Returns

Task



### UpdateAsync(FakturoidInvoice entity)

Updates asynchronously the specified invoice.

| Parameter | Type | Description |
|---|---|---|
| entity | [FakturoidInvoice](#fakturoidinvoice-class) | The invoice to update. |


### Returns

Task<[FakturoidInvoice](#fakturoidinvoice-class)>

Instance of **Altairis.Fakturoid.Client.Models.FakturoidInvoice** class with modified entity.

# FakturoidNumberFormatsProxy Class

Namespace: Altairis.Fakturoid.Client.Proxies

Base class: [FakturoidEntityProxy](#fakturoidentityproxy-class)

Proxy class for working with number formats

## Properties

| Name | Type | Summary |
|---|---|---|
| **Context** | [FakturoidContext](#fakturoidcontext-class) | Gets the related context. |
## Methods

| Name | Returns | Summary |
|---|---|---|
| [**SelectAsync()**](#selectasync) | Task\<IEnumerable\<[FakturoidNumberFormat](#fakturoidnumberformat-class)\>\> | Gets asynchronously list of all number formats. |
## Methods

### SelectAsync()

Gets asynchronously list of all number formats.



### Returns

Task<IEnumerable<[FakturoidNumberFormat](#fakturoidnumberformat-class)>>

List of **Altairis.Fakturoid.Client.Models.FakturoidNumberFormat** instances.

# FakturoidSubjectsProxy Class

Namespace: Altairis.Fakturoid.Client.Proxies

Base class: [FakturoidEntityProxy](#fakturoidentityproxy-class)

Proxy class for working with subjects/contacts.

## Properties

| Name | Type | Summary |
|---|---|---|
| **Context** | [FakturoidContext](#fakturoidcontext-class) | Gets the related context. |
## Methods

| Name | Returns | Summary |
|---|---|---|
| [**CreateAsync(FakturoidSubject entity)**](#createasyncfakturoidsubject-entity) | Task\<int\> | Creates asynchronously the specified new subject. |
| [**DeleteAsync(int id)**](#deleteasyncint-id) | Task | Deletes asynchronously with specified id. |
| [**SearchAsync(string query)**](#searchasyncstring-query) | Task\<IEnumerable\<[FakturoidSubject](#fakturoidsubject-class)\>\> | Searches asynchronously all Subjects in Name, Full name, Email, Email copy, Registration number, VAT number and Private note. |
| [**SearchAsync(int page, string query)**](#searchasyncint-page-string-query) | Task\<IEnumerable\<[FakturoidSubject](#fakturoidsubject-class)\>\> | Searches asynchronously all Subjects in Name, Full name, Email, Email copy, Registration number, VAT number and Private note with pagination. |
| [**SelectAsync(DateTime? createdSince, DateTime? updatedSince, string customId)**](#selectasyncdatetime-createdsince-datetime-updatedsince-string-customid) | Task\<IEnumerable\<[FakturoidSubject](#fakturoidsubject-class)\>\> | Gets asynchronously list of all subjects. |
| [**SelectAsync(int page, DateTime? createdSince, DateTime? updatedSince, string customId)**](#selectasyncint-page-datetime-createdsince-datetime-updatedsince-string-customid) | Task\<IEnumerable\<[FakturoidSubject](#fakturoidsubject-class)\>\> | Gets asynchronously paged list of subjects |
| [**SelectSingleAsync(int id)**](#selectsingleasyncint-id) | Task\<[FakturoidSubject](#fakturoidsubject-class)\> | Selects asynchronously single subject with specified ID. |
| [**UpdateAsync(FakturoidSubject entity)**](#updateasyncfakturoidsubject-entity) | Task\<[FakturoidSubject](#fakturoidsubject-class)\> | Updates asynchronously the specified subject. |
## Methods

### CreateAsync(FakturoidSubject entity)

Creates asynchronously the specified new subject.

| Parameter | Type | Description |
|---|---|---|
| entity | [FakturoidSubject](#fakturoidsubject-class) | The new subject. |


### Returns

Task<int>

ID of newly created subject.

### DeleteAsync(int id)

Deletes asynchronously with specified id.

| Parameter | Type | Description |
|---|---|---|
| id | int | The contact id. |


### Returns

Task



### SearchAsync(string query)

Searches asynchronously all Subjects in Name, Full name, Email, Email copy, Registration number, VAT number and Private note.

| Parameter | Type | Description |
|---|---|---|
| query | string | Search string. |


### Returns

Task<IEnumerable<[FakturoidSubject](#fakturoidsubject-class)>>

Collection of search results.

### SearchAsync(int page, string query)

Searches asynchronously all Subjects in Name, Full name, Email, Email copy, Registration number, VAT number and Private note with pagination.

| Parameter | Type | Description |
|---|---|---|
| query | int | Search string. |
| page | string | The page number. |


### Returns

Task<IEnumerable<[FakturoidSubject](#fakturoidsubject-class)>>

Collection of search results.

### SelectAsync(DateTime? createdSince, DateTime? updatedSince, string customId)

Gets asynchronously list of all subjects.

| Parameter | Type | Description |
|---|---|---|
| customId | DateTime? | The custom identifier used for filtering. |
| createdSince | DateTime? | List only subjects created since certain date. |
| updatedSince | string | List only subjects updated since certain date. |


### Returns

Task<IEnumerable<[FakturoidSubject](#fakturoidsubject-class)>>

List of **Altairis.Fakturoid.Client.Models.FakturoidSubject** instances.

### SelectAsync(int page, DateTime? createdSince, DateTime? updatedSince, string customId)

Gets asynchronously paged list of subjects

| Parameter | Type | Description |
|---|---|---|
| page | int | The page number. |
| createdSince | DateTime? | List only subjects created since certain date. |
| updatedSince | DateTime? | List only subjects updated since certain date. |
| customId | string | The custom identifier used for filtering. |


### Returns

Task<IEnumerable<[FakturoidSubject](#fakturoidsubject-class)>>

List of **Altairis.Fakturoid.Client.Models.FakturoidSubject** instances.

### SelectSingleAsync(int id)

Selects asynchronously single subject with specified ID.

| Parameter | Type | Description |
|---|---|---|
| id | int | The subject id. |


### Returns

Task<[FakturoidSubject](#fakturoidsubject-class)>

Instance of **Altairis.Fakturoid.Client.Models.FakturoidSubject** class.

### UpdateAsync(FakturoidSubject entity)

Updates asynchronously the specified subject.

| Parameter | Type | Description |
|---|---|---|
| entity | [FakturoidSubject](#fakturoidsubject-class) | The subject to update. |


### Returns

Task<[FakturoidSubject](#fakturoidsubject-class)>

Instance of **Altairis.Fakturoid.Client.Models.FakturoidSubject** class with modified entity.

# FakturoidTodosProxy Class

Namespace: Altairis.Fakturoid.Client.Proxies

Base class: [FakturoidEntityProxy](#fakturoidentityproxy-class)

Proxy class for working with todo tasks.

## Properties

| Name | Type | Summary |
|---|---|---|
| **Context** | [FakturoidContext](#fakturoidcontext-class) | Gets the related context. |
## Methods

| Name | Returns | Summary |
|---|---|---|
| [**SelectAsync(DateTime? since)**](#selectasyncdatetime-since) | Task\<IEnumerable\<[FakturoidTodo](#fakturoidtodo-class)\>\> | Gets asynchronously list of all current todos. |
| [**SelectAsync(int page, DateTime? since)**](#selectasyncint-page-datetime-since) | Task\<IEnumerable\<[FakturoidTodo](#fakturoidtodo-class)\>\> | Gets asynchronously paged list of current todos |
| [**ToggleCompletion(int id)**](#togglecompletionint-id) | Task\<[FakturoidTodo](#fakturoidtodo-class)\> | Toggles the completion status of a todo task asynchronously. |
## Methods

### SelectAsync(DateTime? since)

Gets asynchronously list of all current todos.

| Parameter | Type | Description |
|---|---|---|
| since | DateTime? | The date since when todos are to be selected. |


### Returns

Task<IEnumerable<[FakturoidTodo](#fakturoidtodo-class)>>

List of **Altairis.Fakturoid.Client.Models.FakturoidTodo** instances.

### SelectAsync(int page, DateTime? since)

Gets asynchronously paged list of current todos

| Parameter | Type | Description |
|---|---|---|
| page | int | The page number. |
| since | DateTime? | The date since when todos are to be selected. |


### Returns

Task<IEnumerable<[FakturoidTodo](#fakturoidtodo-class)>>

List of **Altairis.Fakturoid.Client.Models.FakturoidTodo** instances.

### ToggleCompletion(int id)

Toggles the completion status of a todo task asynchronously.

| Parameter | Type | Description |
|---|---|---|
| id | int | The ID of the todo task to toggle. |


### Returns

Task<[FakturoidTodo](#fakturoidtodo-class)>

The updated **Altairis.Fakturoid.Client.Models.FakturoidTodo** instance.

# InvoiceMessageType Enum

Namespace: Altairis.Fakturoid.Client.Proxies

Type of e-mail message to be sent.

## Values

| Name | Summary |
|---|---|
| **NoMessage** | Do not actually send anything, just mark invoice as sent |
| **InvoiceMessage** | Predefined message containing link to invoice |
| **PaymentReminderMessage** | Predefined message containing payment reminder |
# InvoicePaymentStatus Enum

Namespace: Altairis.Fakturoid.Client.Proxies

Invoice payment status

## Values

| Name | Summary |
|---|---|
| **Unpaid** | Reset payment status to unpaid. |
| **Paid** | Set status of regular invoice to paid. |
| **ProformaPaid** | Set status of proforma invoice to paid. |
| **PartialProformaPaid** | Set status of partial proforma invoice to paid. |
| **Cancelled** | Set status to cancelled (for proforma or invoice without VAT) |
# InvoiceStatusCondition Enum

Namespace: Altairis.Fakturoid.Client.Proxies

Query status condition for listing invoices

## Values

| Name | Summary |
|---|---|
| **Any** | Any |
| **Open** | Faktura není zaplacena, odeslána ani po splatnosti. |
| **Sent** | Faktura byla odeslána a není po splatnosti. |
| **Overdue** | Faktura je po splatnosti. |
| **Paid** | Faktura je zaplacena. |
| **Cancelled** | Faktura je stornována (pouze neplátci DPH). |
# InvoiceTypeCondition Enum

Namespace: Altairis.Fakturoid.Client.Proxies

Query invoice type condition for listing invoices.

## Values

| Name | Summary |
|---|---|
| **Any** | Any |
| **Proforma** | The proforma invouice. |
| **Regular** | The regular, non-proforma invoice |
