# Altairis.Fakturoid.Client.dll v.2.11.1.0 API documentation

# All types

|   |   |   |
|---|---|---|
| [ExpensePaymentStatus Enum](#expensepaymentstatus-enum) | [GetCustomHttpClient Class](#getcustomhttpclient-class) | [JsonEntityLine Class](#jsonentityline-class) |
| [ExpenseStatusCondition Enum](#expensestatuscondition-enum) | [InternalExtensionMethods Class](#internalextensionmethods-class) | [JsonEvent Class](#jsonevent-class) |
| [FakturoidBankAccountsProxy Class](#fakturoidbankaccountsproxy-class) | [InvoiceMessageType Enum](#invoicemessagetype-enum) | [JsonExpense Class](#jsonexpense-class) |
| [FakturoidContext Class](#fakturoidcontext-class) | [InvoicePaymentStatus Enum](#invoicepaymentstatus-enum) | [JsonExpenseLine Class](#jsonexpenseline-class) |
| [FakturoidEntityProxy Class](#fakturoidentityproxy-class) | [InvoiceStatusCondition Enum](#invoicestatuscondition-enum) | [JsonInvoice Class](#jsoninvoice-class) |
| [FakturoidEventsProxy Class](#fakturoideventsproxy-class) | [InvoiceTypeCondition Enum](#invoicetypecondition-enum) | [JsonInvoiceLine Class](#jsoninvoiceline-class) |
| [FakturoidException Class](#fakturoidexception-class) | [JsonAccessToken Class](#jsonaccesstoken-class) | [JsonRelatedObject Class](#jsonrelatedobject-class) |
| [FakturoidExpensesProxy Class](#fakturoidexpensesproxy-class) | [JsonAccount Class](#jsonaccount-class) | [JsonSubject Class](#jsonsubject-class) |
| [FakturoidInvoicesProxy Class](#fakturoidinvoicesproxy-class) | [JsonAttachment Class](#jsonattachment-class) | [JsonTodo Class](#jsontodo-class) |
| [FakturoidSubjectsProxy Class](#fakturoidsubjectsproxy-class) | [JsonBankAccount Class](#jsonbankaccount-class) | [JsonUser Class](#jsonuser-class) |
| [FakturoidTodosProxy Class](#fakturoidtodosproxy-class) | [JsonEet Class](#jsoneet-class) | [MyHttpClientExtensions Class](#myhttpclientextensions-class) |
# ExpensePaymentStatus Enum

Namespace: Altairis.Fakturoid.Client

Expense payment status

## Values

| Name | Summary |
|---|---|
| **Unpaid** | Reset payment status to unpaid. |
| **Paid** | Set status of regular expense to paid. |
# ExpenseStatusCondition Enum

Namespace: Altairis.Fakturoid.Client

Query status condition for listing expenses

## Values

| Name | Summary |
|---|---|
| **Any** | Any |
| **Open** | Náklad není zaplacen, odeslán ani po splatnosti. |
| **Overdue** | Náklad je po splatnosti. |
| **Paid** | Náklad je zaplacen. |
# FakturoidBankAccountsProxy Class

Namespace: Altairis.Fakturoid.Client

Base class: [FakturoidEntityProxy](#fakturoidentityproxy-class)

Proxy class form working with bank accounts

## Properties

| Name | Type | Summary |
|---|---|---|
| **Context** | [FakturoidContext](#fakturoidcontext-class) | Gets the related context. |
## Methods

| Name | Returns | Summary |
|---|---|---|
| [**SelectAsync()**](#selectasync) | Task\<IEnumerable\<[JsonBankAccount](#jsonbankaccount-class)\>\> | Gets asynchronously list of all bank accounts. |
## Methods

### SelectAsync()

Gets asynchronously list of all bank accounts.



### Returns

Task<IEnumerable<[JsonBankAccount](#jsonbankaccount-class)>>

List of **Altairis.Fakturoid.Client.JsonBankAccount** instances.

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
| **Events** | [FakturoidEventsProxy](#fakturoideventsproxy-class) | Proxy for working with events. |
| **Todos** | [FakturoidTodosProxy](#fakturoidtodosproxy-class) | Proxy for working with todos. |
| **Subjects** | [FakturoidSubjectsProxy](#fakturoidsubjectsproxy-class) | Proxy for working with subjects. |
| **Invoices** | [FakturoidInvoicesProxy](#fakturoidinvoicesproxy-class) | Proxy for working with invoices |
| **Expenses** | [FakturoidExpensesProxy](#fakturoidexpensesproxy-class) | Proxy for working with expenses |
| **BankAccounts** | [FakturoidBankAccountsProxy](#fakturoidbankaccountsproxy-class) | Proxy for working with bank accounts. |
## Constructors

| Name | Summary |
|---|---|
| [**FakturoidContext(string accountName, string clientId, string clientSecret, string userAgent, GetCustomHttpClient getCustomHttpClient)**](#fakturoidcontextstring-accountname-string-clientid-string-clientsecret-string-useragent-getcustomhttpclient-getcustomhttpclient) | Initializes a new instance of the **Altairis.Fakturoid.Client.FakturoidContext** class. |
## Methods

| Name | Returns | Summary |
|---|---|---|
| [**GetAccountInfo()**](#getaccountinfo) | [JsonAccount](#jsonaccount-class) | Gets the account information. |
## Constructors

### FakturoidContext(string accountName, string clientId, string clientSecret, string userAgent, GetCustomHttpClient getCustomHttpClient)

Initializes a new instance of the **Altairis.Fakturoid.Client.FakturoidContext** class.

| Parameter | Type | Description |
|---|---|---|
| accountName | string | Account name (accountName). |
| clientId | string | The client ID for OAuth 2 Client Credentials Flow. |
| clientSecret | string | The client secret for OAuth 2 Client Credentials Flow. |
| userAgent | string | The User-Agent HTTP header value. |
| getCustomHttpClient | [GetCustomHttpClient](#getcustomhttpclient-class) | Getter for custom http client |


## Methods

### GetAccountInfo()

Gets the account information.



### Returns

[JsonAccount](#jsonaccount-class)

Instance of **Altairis.Fakturoid.Client.JsonAccount** class containing the account information.

# FakturoidEntityProxy Class

Namespace: Altairis.Fakturoid.Client

Proxy class for working with any Fakturoid entity

## Properties

| Name | Type | Summary |
|---|---|---|
| **Context** | [FakturoidContext](#fakturoidcontext-class) | Gets the related context. |
# FakturoidEventsProxy Class

Namespace: Altairis.Fakturoid.Client

Base class: [FakturoidEntityProxy](#fakturoidentityproxy-class)

Proxy class for working with events

## Properties

| Name | Type | Summary |
|---|---|---|
| **Context** | [FakturoidContext](#fakturoidcontext-class) | Gets the related context. |
## Methods

| Name | Returns | Summary |
|---|---|---|
| [**SelectAsync(DateTime? since, int? subjectId)**](#selectasyncdatetime-since-int-subjectid) | Task\<IEnumerable\<[JsonEvent](#jsonevent-class)\>\> | Gets asynchronously list of all current events. |
| [**SelectAsync(int page, DateTime? since)**](#selectasyncint-page-datetime-since) | Task\<IEnumerable\<[JsonEvent](#jsonevent-class)\>\> | Gets asynchronously list of current events, paged by 40. |
## Methods

### SelectAsync(DateTime? since, int? subjectId)

Gets asynchronously list of all current events.

| Parameter | Type | Description |
|---|---|---|
| since | DateTime? | The date since when events are to be selected. |


### Returns

Task<IEnumerable<[JsonEvent](#jsonevent-class)>>

List of **Altairis.Fakturoid.Client.JsonEvent** instances.

### SelectAsync(int page, DateTime? since)

Gets asynchronously list of current events, paged by 40.

| Parameter | Type | Description |
|---|---|---|
| page | int | The page number. |
| since | DateTime? | The date since when events are to be selected. |


### Returns

Task<IEnumerable<[JsonEvent](#jsonevent-class)>>

List of **Altairis.Fakturoid.Client.JsonEvent** instances.

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


# FakturoidExpensesProxy Class

Namespace: Altairis.Fakturoid.Client

Base class: [FakturoidEntityProxy](#fakturoidentityproxy-class)

Proxy class for working with invoices.

## Properties

| Name | Type | Summary |
|---|---|---|
| **Context** | [FakturoidContext](#fakturoidcontext-class) | Gets the related context. |
## Methods

| Name | Returns | Summary |
|---|---|---|
| [**CreateAsync(JsonExpense entity)**](#createasyncjsonexpense-entity) | Task\<int\> | Creates asynchronously the specified new expense. |
| [**DeleteAsync(int id)**](#deleteasyncint-id) | Task | Deletes asynchronously expense with specified id. |
| [**SelectAsync(ExpenseStatusCondition status, int? subjectId, DateTime? since, string number)**](#selectasyncexpensestatuscondition-status-int-subjectid-datetime-since-string-number) | Task\<IEnumerable\<[JsonExpense](#jsonexpense-class)\>\> | Gets asynchronously list of all invoices. |
| [**SelectAsync(int page, ExpenseStatusCondition status, int? subjectId, DateTime? since, string number)**](#selectasyncint-page-expensestatuscondition-status-int-subjectid-datetime-since-string-number) | Task\<IEnumerable\<[JsonExpense](#jsonexpense-class)\>\> | Gets asynchronously paged list of invoices. |
| [**SelectSingleAsync(int id)**](#selectsingleasyncint-id) | Task\<[JsonExpense](#jsonexpense-class)\> | Selects asynchronously single expense with specified ID. |
| [**SetAttachmentAsync(int id, string filePath)**](#setattachmentasyncint-id-string-filepath) | Task | Sets attachment for invoice. |
| [**SetAttachmentAsync(int id, string mimeType, byte[] fileContent)**](#setattachmentasyncint-id-string-mimetype-byte-filecontent) | Task | Sets attachment for invoice. |
| [**SetPaymentStatusAsync(int id, ExpensePaymentStatus status)**](#setpaymentstatusasyncint-id-expensepaymentstatus-status) | Task | Sets asynchronously the expense payment status. |
| [**SetPaymentStatusAsync(int id, ExpensePaymentStatus status, DateTime effectiveDate)**](#setpaymentstatusasyncint-id-expensepaymentstatus-status-datetime-effectivedate) | Task | Sets asynchronously the expense payment status. |
| [**UpdateAsync(JsonExpense entity)**](#updateasyncjsonexpense-entity) | Task\<[JsonExpense](#jsonexpense-class)\> | Updates asynchronously the specified expense. |
## Methods

### CreateAsync(JsonExpense entity)

Creates asynchronously the specified new expense.

| Parameter | Type | Description |
|---|---|---|
| entity | [JsonExpense](#jsonexpense-class) | The new expense. |


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

Task<IEnumerable<[JsonExpense](#jsonexpense-class)>>

List of **Altairis.Fakturoid.Client.JsonExpense** instances.

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

Task<IEnumerable<[JsonExpense](#jsonexpense-class)>>

List of **Altairis.Fakturoid.Client.JsonExpense** instances.

### SelectSingleAsync(int id)

Selects asynchronously single expense with specified ID.

| Parameter | Type | Description |
|---|---|---|
| id | int | The expense id. |


### Returns

Task<[JsonExpense](#jsonexpense-class)>

Instance of **Altairis.Fakturoid.Client.JsonExpense** class.

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

Instance of **Altairis.Fakturoid.Client.JsonExpense** class with modified entity.

### SetPaymentStatusAsync(int id, ExpensePaymentStatus status, DateTime effectiveDate)

Sets asynchronously the expense payment status.

| Parameter | Type | Description |
|---|---|---|
| id | int | The expense id. |
| status | [ExpensePaymentStatus](#expensepaymentstatus-enum) | The new payment status. |
| effectiveDate | DateTime | The date when payment was performed. |


### Returns

Task



### UpdateAsync(JsonExpense entity)

Updates asynchronously the specified expense.

| Parameter | Type | Description |
|---|---|---|
| entity | [JsonExpense](#jsonexpense-class) | The expense to update. |


### Returns

Task<[JsonExpense](#jsonexpense-class)>

Instance of **Altairis.Fakturoid.Client.JsonExpense** class with modified entity.

# FakturoidInvoicesProxy Class

Namespace: Altairis.Fakturoid.Client

Base class: [FakturoidEntityProxy](#fakturoidentityproxy-class)

Proxy class for working with invoices.

## Properties

| Name | Type | Summary |
|---|---|---|
| **Context** | [FakturoidContext](#fakturoidcontext-class) | Gets the related context. |
## Methods

| Name | Returns | Summary |
|---|---|---|
| [**CreateAsync(JsonInvoice entity)**](#createasyncjsoninvoice-entity) | Task\<int\> | Creates asynchronously the specified new invoice. |
| [**DeleteAsync(int id)**](#deleteasyncint-id) | Task | Deletes asynchronously invoice with specified id. |
| [**SelectAsync(InvoiceTypeCondition type, InvoiceStatusCondition status, int? subjectId, DateTime? since, string number)**](#selectasyncinvoicetypecondition-type-invoicestatuscondition-status-int-subjectid-datetime-since-string-number) | Task\<IEnumerable\<[JsonInvoice](#jsoninvoice-class)\>\> | Gets asynchronously list of all invoices. |
| [**SelectAsync(int page, InvoiceTypeCondition type, InvoiceStatusCondition status, int? subjectId, DateTime? since, string number)**](#selectasyncint-page-invoicetypecondition-type-invoicestatuscondition-status-int-subjectid-datetime-since-string-number) | Task\<IEnumerable\<[JsonInvoice](#jsoninvoice-class)\>\> | Gets asynchronously paged list of invoices. |
| [**SelectSingleAsync(int id)**](#selectsingleasyncint-id) | Task\<[JsonInvoice](#jsoninvoice-class)\> | Selects asynchronously single invoice with specified ID. |
| [**SendMessageAsync(int id, InvoiceMessageType messageType)**](#sendmessageasyncint-id-invoicemessagetype-messagetype) | Task | Sends asynchronously e-mail message for the specified invoice. |
| [**SetAttachmentAsync(int id, string filePath)**](#setattachmentasyncint-id-string-filepath) | Task | Sets attachment for invoice. |
| [**SetAttachmentAsync(int id, string mimeType, byte[] fileContent)**](#setattachmentasyncint-id-string-mimetype-byte-filecontent) | Task | Sets attachment for invoice. |
| [**SetPaymentStatusAsync(int id, InvoicePaymentStatus status)**](#setpaymentstatusasyncint-id-invoicepaymentstatus-status) | Task | Sets asynchronously the invoice payment status. |
| [**SetPaymentStatusAsync(int id, InvoicePaymentStatus status, DateTime effectiveDate)**](#setpaymentstatusasyncint-id-invoicepaymentstatus-status-datetime-effectivedate) | Task | Sets asynchronously the invoice payment status. |
| [**UpdateAsync(JsonInvoice entity)**](#updateasyncjsoninvoice-entity) | Task\<[JsonInvoice](#jsoninvoice-class)\> | Updates asynchronously the specified invoice. |
## Methods

### CreateAsync(JsonInvoice entity)

Creates asynchronously the specified new invoice.

| Parameter | Type | Description |
|---|---|---|
| entity | [JsonInvoice](#jsoninvoice-class) | The new invoice. |


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

Task<IEnumerable<[JsonInvoice](#jsoninvoice-class)>>

List of **Altairis.Fakturoid.Client.JsonInvoice** instances.

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

Task<IEnumerable<[JsonInvoice](#jsoninvoice-class)>>

List of **Altairis.Fakturoid.Client.JsonInvoice** instances.

### SelectSingleAsync(int id)

Selects asynchronously single invoice with specified ID.

| Parameter | Type | Description |
|---|---|---|
| id | int | The invoice id. |


### Returns

Task<[JsonInvoice](#jsoninvoice-class)>

Instance of **Altairis.Fakturoid.Client.JsonInvoice** class.

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

Instance of **Altairis.Fakturoid.Client.JsonInvoice** class with modified entity.

### SetPaymentStatusAsync(int id, InvoicePaymentStatus status, DateTime effectiveDate)

Sets asynchronously the invoice payment status.

| Parameter | Type | Description |
|---|---|---|
| id | int | The invoice id. |
| status | [InvoicePaymentStatus](#invoicepaymentstatus-enum) | The new payment status. |
| effectiveDate | DateTime | The date when payment was performed. |


### Returns

Task



### UpdateAsync(JsonInvoice entity)

Updates asynchronously the specified invoice.

| Parameter | Type | Description |
|---|---|---|
| entity | [JsonInvoice](#jsoninvoice-class) | The invoice to update. |


### Returns

Task<[JsonInvoice](#jsoninvoice-class)>

Instance of **Altairis.Fakturoid.Client.JsonInvoice** class with modified entity.

# FakturoidSubjectsProxy Class

Namespace: Altairis.Fakturoid.Client

Base class: [FakturoidEntityProxy](#fakturoidentityproxy-class)

Proxy class for working with subjects/contacts.

## Properties

| Name | Type | Summary |
|---|---|---|
| **Context** | [FakturoidContext](#fakturoidcontext-class) | Gets the related context. |
## Methods

| Name | Returns | Summary |
|---|---|---|
| [**CreateAsync(JsonSubject entity)**](#createasyncjsonsubject-entity) | Task\<int\> | Creates asynchronously the specified new subject. |
| [**DeleteAsync(int id)**](#deleteasyncint-id) | Task | Deletes asynchronously with specified id. |
| [**SearchAsync(string searchTerm)**](#searchasyncstring-searchterm) | Task\<IEnumerable\<[JsonSubject](#jsonsubject-class)\>\> | Searches asynchronously all Subjects in Name, Full name, Email, Email copy, Registration number, VAT number and Private note. |
| [**SelectAsync(int page)**](#selectasyncint-page) | Task\<IEnumerable\<[JsonSubject](#jsonsubject-class)\>\> | Gets asynchronously paged list of subjects |
| [**SelectAsync(string customId, DateTime? createdSince, DateTime? updatedSince)**](#selectasyncstring-customid-datetime-createdsince-datetime-updatedsince) | Task\<IEnumerable\<[JsonSubject](#jsonsubject-class)\>\> | Gets asynchronously list of all subjects. |
| [**SelectSingleAsync(int id)**](#selectsingleasyncint-id) | Task\<[JsonSubject](#jsonsubject-class)\> | Selects asynchronously single subject with specified ID. |
| [**UpdateAsync(JsonSubject entity)**](#updateasyncjsonsubject-entity) | Task\<[JsonSubject](#jsonsubject-class)\> | Updates asynchronously the specified subject. |
## Methods

### CreateAsync(JsonSubject entity)

Creates asynchronously the specified new subject.

| Parameter | Type | Description |
|---|---|---|
| entity | [JsonSubject](#jsonsubject-class) | The new subject. |


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



### SearchAsync(string searchTerm)

Searches asynchronously all Subjects in Name, Full name, Email, Email copy, Registration number, VAT number and Private note.

| Parameter | Type | Description |
|---|---|---|
| searchTerm | string | Search string. |


### Returns

Task<IEnumerable<[JsonSubject](#jsonsubject-class)>>

Collection if search results.

### SelectAsync(int page)

Gets asynchronously paged list of subjects

| Parameter | Type | Description |
|---|---|---|
| page | int | The page number. |


### Returns

Task<IEnumerable<[JsonSubject](#jsonsubject-class)>>

List of **Altairis.Fakturoid.Client.JsonSubject** instances.

### SelectAsync(string customId, DateTime? createdSince, DateTime? updatedSince)

Gets asynchronously list of all subjects.

| Parameter | Type | Description |
|---|---|---|
| customId | string | The custom identifier used for filtering. |
| createdSince | DateTime? | List only subjects created since certain date. |
| updatedSince | DateTime? | List only subjects updated since certain date. |


### Returns

Task<IEnumerable<[JsonSubject](#jsonsubject-class)>>

List of **Altairis.Fakturoid.Client.JsonSubject** instances.

### SelectSingleAsync(int id)

Selects asynchronously single subject with specified ID.

| Parameter | Type | Description |
|---|---|---|
| id | int | The subject id. |


### Returns

Task<[JsonSubject](#jsonsubject-class)>

Instance of **Altairis.Fakturoid.Client.JsonSubject** class.

### UpdateAsync(JsonSubject entity)

Updates asynchronously the specified subject.

| Parameter | Type | Description |
|---|---|---|
| entity | [JsonSubject](#jsonsubject-class) | The subject to update. |


### Returns

Task<[JsonSubject](#jsonsubject-class)>

Instance of **Altairis.Fakturoid.Client.JsonSubject** class with modified entity.

# FakturoidTodosProxy Class

Namespace: Altairis.Fakturoid.Client

Base class: [FakturoidEntityProxy](#fakturoidentityproxy-class)

Proxy class for working with todo tasks.

## Properties

| Name | Type | Summary |
|---|---|---|
| **Context** | [FakturoidContext](#fakturoidcontext-class) | Gets the related context. |
## Methods

| Name | Returns | Summary |
|---|---|---|
| [**SelectAsync(DateTime? since)**](#selectasyncdatetime-since) | Task\<IEnumerable\<[JsonTodo](#jsontodo-class)\>\> | Gets asynchronously list of all current todos. |
| [**SelectAsync(int page, DateTime? since)**](#selectasyncint-page-datetime-since) | Task\<IEnumerable\<[JsonTodo](#jsontodo-class)\>\> | Gets asynchronously paged list of current todos |
## Methods

### SelectAsync(DateTime? since)

Gets asynchronously list of all current todos.

| Parameter | Type | Description |
|---|---|---|
| since | DateTime? | The date since when todos are to be selected. |


### Returns

Task<IEnumerable<[JsonTodo](#jsontodo-class)>>

List of **Altairis.Fakturoid.Client.JsonTodo** instances.

### SelectAsync(int page, DateTime? since)

Gets asynchronously paged list of current todos

| Parameter | Type | Description |
|---|---|---|
| page | int | The page number. |
| since | DateTime? | The date since when todos are to be selected. |


### Returns

Task<IEnumerable<[JsonTodo](#jsontodo-class)>>

List of **Altairis.Fakturoid.Client.JsonTodo** instances.

# GetCustomHttpClient Class

Namespace: Altairis.Fakturoid.Client

Base class: MulticastDelegate

To provide custom http client

## Properties

| Name | Type | Summary |
|---|---|---|
| **Target** | Object |  |
| **Method** | MethodInfo |  |
## Constructors

| Name | Summary |
|---|---|
| [**GetCustomHttpClient(Object object, IntPtr method)**](#getcustomhttpclientobject-object-intptr-method) |  |
## Methods

| Name | Returns | Summary |
|---|---|---|
| [**BeginInvoke(Uri uri, AsyncCallback callback, Object object)**](#begininvokeuri-uri-asynccallback-callback-object-object) | IAsyncResult |  |
| [**EndInvoke(IAsyncResult result)**](#endinvokeiasyncresult-result) | HttpClient |  |
| [**Invoke(Uri uri)**](#invokeuri-uri) | HttpClient |  |
## Constructors

### GetCustomHttpClient(Object object, IntPtr method)




## Methods

### BeginInvoke(Uri uri, AsyncCallback callback, Object object)




### Returns

IAsyncResult


### EndInvoke(IAsyncResult result)




### Returns

HttpClient


### Invoke(Uri uri)




### Returns

HttpClient


# InternalExtensionMethods Class

Namespace: Altairis.Fakturoid.Client


## Methods

| Name | Returns | Summary |
|---|---|---|
| [**EnsureFakturoidSuccess(HttpResponseMessage r)**](#ensurefakturoidsuccesshttpresponsemessage-r) | void |  |
## Methods

### EnsureFakturoidSuccess(HttpResponseMessage r)




# InvoiceMessageType Enum

Namespace: Altairis.Fakturoid.Client

Type of e-mail message to be sent.

## Values

| Name | Summary |
|---|---|
| **NoMessage** | Do not actually send anything, just mark invoice as sent |
| **InvoiceMessage** | Predefined message containing link to invoice |
| **PaymentReminderMessage** | Predefined message containing payment reminder |
# InvoicePaymentStatus Enum

Namespace: Altairis.Fakturoid.Client

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

Namespace: Altairis.Fakturoid.Client

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

Namespace: Altairis.Fakturoid.Client

Query invoice type condition for listing invoices.

## Values

| Name | Summary |
|---|---|
| **Any** | Any |
| **Proforma** | The proforma invouice. |
| **Regular** | The regular, non-proforma invoice |
# JsonAccessToken Class

Namespace: Altairis.Fakturoid.Client


## Properties

| Name | Type | Summary |
|---|---|---|
| **AccessToken** | string |  |
| **TokenType** | string |  |
| **ExpiresIn** | int |  |
# JsonAccount Class

Namespace: Altairis.Fakturoid.Client

Account information, as received from JSON API.

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
| **CreatedAt** | string | Account creation date. |
| **UpdatedAt** | string | The date the account was last modified. |
# JsonAttachment Class

Namespace: Altairis.Fakturoid.Client

User account information, as received from JSON API.
Single invoice

## Properties

| Name | Type | Summary |
|---|---|---|
| **file_name** | string | Název souboru |
| **content_type** | string | MIME type souboru |
| **download_url** | string | URL pro download přílohy přes API |
# JsonBankAccount Class

Namespace: Altairis.Fakturoid.Client

Bank account information, as received from JSON API.

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
| **CreatedAt** | DateTime | Date and time of bank account creation. |
| **UpdatedAt** | DateTime | Date and time of last bank account update. |
# JsonEet Class

Namespace: Altairis.Fakturoid.Client

EET Information, as recieved from API

## Properties

| Name | Type | Summary |
|---|---|---|
| **id** | long | ID záznamu |
| **vat_no** | string | DIČ účtu ve Fakturoidu |
| **number** | string | Pořadové číslo dokladu |
| **store** | long | ID provozovny |
| **cash_register** | string | Číslo pokladny |
| **paid_at** | DateTimeOffset | Datum a čas tržby |
| **vat_base0** | Object | Základ nepodléhající DPH |
| **vat1** | string | DPH pro základní sazbu |
| **vat_base1** | string | Základ pro základní sazbu DPH (21 %) |
| **vat2** | Object | DPH pro 1. sníženou sazbu DPH |
| **vat_base2** | Object | Základ pro 1. sníženou sazbu DPH (15 %) |
| **vat3** | Object | DPH pro 2. sníženou sazbu DPH |
| **vat_base3** | Object | Základ pro 2. sníženou sazbu DPH (10 %) |
| **total** | string | Celková částka tržby |
| **fik** | string | FIK kód |
| **bkp** | string | BKP kód |
| **pkp** | string | PKP kód |
| **status** | string | Stav zaevidování:<br>   waiting - čeká se na první odpověď serveru EET<br>   pkp - na faktuře se zobrazí PKP kód<br>   fik - na faktuře se zobrazí FIK kód |
| **fik_received_at** | DateTimeOffset | Datum a čas získání FIK ze serverů EET |
| **external** | bool | Tržba je zaevidována mimo Fakturoid a potřebné kódy jsou zadány přes API |
| **attempts** | long | Počet pokusů o zaevidování tržby |
| **last_attempt_at** | DateTimeOffset | Datum a čas posledního pokusu o zaevidování tržby |
| **last_uuid** | Guid | UUID posledního pokusu o zaevidování tržby |
| **playground** | bool | Evidováno v EET Playground prostředí |
| **invoice_id** | long | ID faktury, ke které EET záznam patří |
| **created_at** | DateTimeOffset | Datum a čas vytvoření záznamu |
| **updated_at** | DateTimeOffset | Datum a čas poslední úpravy záznamu |
# JsonEntityLine Class

Namespace: Altairis.Fakturoid.Client

Represents single line of entity, as received from JSON API.

## Properties

| Name | Type | Summary |
|---|---|---|
| **name** | string | Název položky |
| **quantity** | decimal | Množství |
| **unit_name** | string | Měrná jednotka |
| **unit_price** | decimal | Jednotková cena |
| **vat_rate** | decimal | Sazba DPH |
# JsonEvent Class

Namespace: Altairis.Fakturoid.Client

Event, as received from JSON API.

## Properties

| Name | Type | Summary |
|---|---|---|
| **Name** | string | Event name |
| **CreatedAt** | DateTime | Date and time of event creation |
| **Text** | string | Text of the event |
| **RelatedObjects** | [JsonRelatedObject](#jsonrelatedobject-class)[] | Attributes of objects related to the event |
| **User** | [JsonUser](#jsonuser-class) | User details |
| **Params** | Object | Parameters with details about event, specific for each type of event |
# JsonExpense Class

Namespace: Altairis.Fakturoid.Client

User account information, as received from JSON API.
Single invoice

## Properties

| Name | Type | Summary |
|---|---|---|
| **id** | int | Identifikátor nákladu |
| **custom_id** | string | identifikátor nákladu ve vaší aplikaci |
| **number** | string | číslo nákladu (Př: N20150101, musí odpovídat formátu čísla v nastavení účtu, doplní se automaticky) |
| **original_number** | string | číslo dokladu (uvedené na přijaté faktuře) |
| **variable_symbol** | string | Variabilní symbol |
| **supplier_name** | string | Nazev firmy kontaktu |
| **supplier_street** | string | kontakt ulice |
| **supplier_city** | string | kontakt město |
| **supplier_zip** | string | kontakt PSČ |
| **supplier_country** | string | kontakt země |
| **supplier_registration_no** | string | kontakt IČ |
| **supplier_vat_no** | string | kontakt DIČ |
| **subject_id** | int | ID kontaktu příjemce |
| **status** | string | Stav nákladu - open/overdue/paid |
| **document_type** | string | typ dokumentu - bill/invoice/other |
| **issued_on** | DateTime? | Datum vystavení (zobrazeno na faktuře) |
| **received_on** | DateTime? | Datum přijetí (nepovinné - doplní se dle duzp) |
| **taxable_fulfillment_due** | DateTime? | Datum zdanitelného plnění (nepovinné - doplní se dnes) |
| **due_on** | DateTime? | Datum splatnosti (doplní se podle due) |
| **paid_on** | DateTime? | Datum a čas zaplacení nákladu |
| **description** | string | popis (nepovinné) |
| **private_note** | string | Soukromá poznámka (nepovinné) |
| **tags** | ICollection\<string\> | Seznam tagů nákladu |
| **bank_account** | string | Číslo bankovního účtu (nepovinné - doplní se z účtu) |
| **iban** | string | IBAN (nepovinné - doplní se z účtu) |
| **swift_bic** | string | BIC (nepovinné - doplní se z účtu) |
| **payment_method** | string | Způsob úhrady: bank (bankovní převod) / cash (hotově) / cod (dobírka) |
| **currency** | string | Kód měny (nepovinné - doplní se z účtu, 3 znaky) |
| **exchange_rate** | decimal | Kurz (nepovinné) |
| **transferred_tax_liability** | bool | Přenesená daňová povinnost |
| **vat_price_mode** | string | Způsob zadávání cen do řádků (hodnoty: null, without_vat, with_vat, default: dle účtu).<br>Je ignorováno, pokud účet je neplátce DPH nebo je zapnuta přenesená daňová povinnost. |
| **supply_code** | int? | Kód plnění pro souhrnná hlášení (pouze pro zahraniční nákladu do EU, nepovinné) |
| **round_total** | bool? | Zaokrouhlit cenu s DPH při vystavení (nepovinné) |
| **subtotal** | decimal | Součet bez DPH |
| **native_subtotal** | decimal | Součet bez DPH v měně účtu |
| **total** | decimal | Součet včetně DPH |
| **native_total** | decimal | Součet včetně DPH v měně účtu |
| **attachment** | [JsonAttachment](#jsonattachment-class) | Příloha |
| **html_url** | string | Adresa nákladu v GUI |
| **url** | string | API adresa nákladu |
| **pdf_url** | string | API adresa pro stažení nákladu v PDF |
| **subject_url** | string | API adresa kontaktu příjemce |
| **created_at** | DateTime? | Datum vytvoreni nákladu |
| **updated_at** | DateTime? | Datum poslední aktualizace nákladu |
| **lines** | ICollection\<[JsonExpenseLine](#jsonexpenseline-class)\> | Položky nákladu |
# JsonExpenseLine Class

Namespace: Altairis.Fakturoid.Client

Base class: [JsonEntityLine](#jsonentityline-class)

Expense line information, as received from JSON API.

## Properties

| Name | Type | Summary |
|---|---|---|
| **name** | string | Název položky |
| **quantity** | decimal | Množství |
| **unit_name** | string | Měrná jednotka |
| **unit_price** | decimal | Jednotková cena |
| **vat_rate** | decimal | Sazba DPH |
# JsonInvoice Class

Namespace: Altairis.Fakturoid.Client

User account information, as received from JSON API.
Single invoice

## Properties

| Name | Type | Summary |
|---|---|---|
| **custom_id** | string | identifikátor faktury ve vaší aplikaci, nepovinné |
| **id** | int | Identifikátor faktury |
| **proforma** | bool | Příznak proformy |
| **partial_proforma** | bool? | Přiznak zda je proforma na plnou částku |
| **number** | string | Číslo faktury (např.: 2011-0001, musí odpovídat formátu čísla v nastavení účtu) |
| **number_format_id** | int | ID číselné řady	- nepovinné |
| **variable_symbol** | string | Variabilní symbol |
| **your_name** | string | Vaše obchodní jméno |
| **your_street** | string | Vaše ulice |
| **your_street2** | string | Vaše ulice - druhý řádek |
| **your_city** | string | Vaše město |
| **your_zip** | string | Vaše PSČ |
| **your_country** | string | Vaše země |
| **your_registration_no** | string | Vaše IČ |
| **your_vat_no** | string | Vaše DIČ |
| **your_local_vat_no** | string | vaše SK DIČ (pouze pro Slovensko, nezačíná kódem země) - nepovinné |
| **client_name** | string | Obchodní jméno příjemce |
| **client_street** | string | Ulice příjemce |
| **client_street2** | string | Ulice příjemce - druhý řádek |
| **client_city** | string | Místo příjemce |
| **client_zip** | string | PSČ příjemce |
| **client_country** | string | Země příjemce |
| **client_registration_no** | string | IČ příjemce |
| **client_vat_no** | string | DIČ příjemce |
| **client_local_vat_no** | string | SK DIČ kontaktu (pouze pro Slovensko, nezačíná kódem země) - Nepovinné |
| **subject_id** | int | ID kontaktu příjemce |
| **subject_custom_id** | string | identifikátor kontaktu ve vaší aplikaci - nepovinné |
| **generator_id** | int? | ID šablony ze které byla faktura vystavena (nepovinné) |
| **related_id** | int? | ID proformy/faktury (nepovinné) |
| **correction** | bool? | Opravný daňový doklad (false = faktura/proforma, nepovinné) |
| **correction_id** | int? | ID opravovaného dokladu, zdává se pouze pokud je correction=true, na opravovaný doklad<br>se doplní automaticky doplní ID opravného daňového dokladu (nepovinné) |
| **token** | string | Token pro public akci |
| **status** | string | Stav faktury - open/sent/overdue/paid |
| **order_number** | string | Číslo objednávky (nepovinné) |
| **issued_on** | DateTime? | Datum vystavení (zobrazeno na faktuře) |
| **taxable_fulfillment_due** | DateTime? | Datum zdanitelného plnění (nepovinné - doplní se dnes) |
| **due** | int? | Počet dní, než bude po splatnosti (nepovinné - doplní se z účtu) |
| **due_on** | DateTime? | Datum splatnosti (doplní se podle due) |
| **sent_at** | DateTime? | Datum a čas odeslání faktury |
| **paid_at** | DateTime? | Datum a čas zaplacení faktury |
| **reminder_sent_at** | DateTime? | Datum a čas odeslání upomínky |
| **accepted_at** | DateTime? | Datum a čas odsouhlasení faktury klientem |
| **cancelled_at** | DateTime? | Datum stornování faktury (pouze pro neplátce DPH) |
| **note** | string | Text před položkami faktury (nepovinné - doplní se z účtu) |
| **footer_note** | string | Patička faktury (nepovinné - doplní se z účtu) |
| **private_note** | string | Soukromá poznámka (nepovinné) |
| **tags** | ICollection\<string\> | Seznam tagů faktury |
| **bank_account_id** | int? | ID bankovního účtu (nepovinné - použije se výchozí bankovní účet) |
| **bank_account** | string | Číslo bankovního účtu (nepovinné - doplní se z účtu) |
| **iban** | string | IBAN (nepovinné - doplní se z účtu) |
| **iban_visibility** | string | viditelnost IBANu |
| **swift_bic** | string | BIC (nepovinné - doplní se z účtu) |
| **show_already_paid_note_in_pdf** | bool | zobrazí na faktuře "Neplaťte již uhrazeno" v jazyce faktury **bez ohledu na stav platby**. Lze nastavit pouze pro faktury, pro proformy je vždy `false`. Pro faktury vystavené z plné proformy je vždy `true`. - nepovinné |
| **payment_method** | string | Způsob úhrady: bank (bankovní převod) / cash (hotově) / cod (dobírka) |
| **currency** | string | Kód měny (nepovinné - doplní se z účtu, 3 znaky) |
| **exchange_rate** | decimal | Kurz (nepovinné) |
| **paypal** | bool? | Tlačítko pro platbu PayPalem - true/false (nepovinné) |
| **language** | string | Jazyk faktury |
| **transferred_tax_liability** | bool | Přenesená daňová povinnost |
| **supply_code** | int? | Kód plnění pro souhrnná hlášení (pouze pro zahraniční faktury do EU, nepovinné) |
| **eu_electronic_service** | bool? | Příznak, pokud je faktura v režimu MOSS (nepovinné) |
| **oss** | string | příznak, jestli je faktura v režimu OSS, povolené hodnoty disabled - vypnuto, service - služba, goods - zboží. Prázdná hodnota znamená disabled, nepovinné |
| **vat_price_mode** | string | Způsob zadávání cen do řádků (hodnoty: null, without_vat, with_vat, default: dle účtu).<br>Je ignorováno, pokud účet je neplátce DPH nebo je zapnuta přenesená daňová povinnost. |
| **round_total** | bool? | Zaokrouhlit cenu s DPH při vystavení (nepovinné) |
| **subtotal** | decimal | Součet bez DPH |
| **native_subtotal** | decimal | Součet bez DPH v měně účtu |
| **total** | decimal | Součet včetně DPH |
| **native_total** | decimal | Součet včetně DPH v měně účtu |
| **remaining_amount** | decimal | Částka k zaplacení |
| **remaining_native_amount** | decimal | Částka k zaplacení v měně účtu |
| **paid_amount** | decimal | skutečně zaplacená částka |
| **attachment** | [JsonAttachment](#jsonattachment-class) | Příloha |
| **html_url** | string | Adresa faktury v GUI |
| **public_html_url** | string | Veřejná HTML adresa faktury |
| **url** | string | API adresa faktury |
| **pdf_url** | string | API adresa pro stažení faktury v PDF |
| **subject_url** | string | API adresa kontaktu příjemce |
| **updated_at** | DateTime? | Datum poslední aktualizace faktury |
| **lines** | ICollection\<[JsonInvoiceLine](#jsoninvoiceline-class)\> | Položky faktury |
| **eet** | bool? | true - Vystavená faktura se zaeviduje do EET / false - Vystavená faktura se nezaeviduje do EET |
| **eet_store** | string | Pokladna |
| **eet_cash_register** | string | Číslo provozovny |
| **eet_records** | [JsonEet](#jsoneet-class)[] | EET záznamy	- nepovinné |
# JsonInvoiceLine Class

Namespace: Altairis.Fakturoid.Client

Base class: [JsonEntityLine](#jsonentityline-class)

Invoice line information, as received from JSON API.

## Properties

| Name | Type | Summary |
|---|---|---|
| **name** | string | Název položky |
| **quantity** | decimal | Množství |
| **unit_name** | string | Měrná jednotka |
| **unit_price** | decimal | Jednotková cena |
| **vat_rate** | decimal | Sazba DPH |
# JsonRelatedObject Class

Namespace: Altairis.Fakturoid.Client

Represents an object related to the event.

## Properties

| Name | Type | Summary |
|---|---|---|
| **Type** | string | Type of the object related to the event<br>Values: Invoice, Subject, Expense, Generator, RecurringGenerator, ExpenseGenerator, Estimate |
| **Id** | int | ID of the object related to event |
# JsonSubject Class

Namespace: Altairis.Fakturoid.Client

Subject (contact), as received from JSON API.

## Properties

| Name | Type | Summary |
|---|---|---|
| **id** | int | Unique identifier in Fakturoid |
| **custom_id** | string | Identifier in your application |
| **user_id** | int | User ID who created the subject |
| **type** | string | Type of subject. Values: "customer", "supplier", "both". Default: "customer" |
| **name** | string | Name of the subject |
| **full_name** | string | Contact person name |
| **email** | string | Main email address to receive invoice emails |
| **email_copy** | string | Email copy address to receive invoice emails |
| **phone** | string | Phone number |
| **web** | string | Web page |
| **street** | string | Street |
| **city** | string | City |
| **zip** | string | ZIP or postal code |
| **country** | string | Country (ISO code). Default: Account setting |
| **has_delivery_address** | bool | Enable delivery address. Default: false |
| **delivery_name** | string | Delivery address name |
| **delivery_street** | string | Delivery address street |
| **delivery_city** | string | Delivery address city |
| **delivery_zip** | string | Delivery address ZIP or postal code |
| **delivery_country** | string | Delivery address country (ISO code). Default: Account setting |
| **due** | int | Number of days until an invoice is due for this subject. Default: Inherit from account settings |
| **currency** | string | Currency (ISO code). Default: Inherit from account settings |
| **language** | string | Invoice language. Default: Inherit from account settings |
| **private_note** | string | Private note |
| **registration_no** | string | Registration number (IČO) |
| **vat_no** | string | VAT-payer VAT number (DIČ, IČ DPH in Slovakia, typically starts with the country code) |
| **local_vat_no** | string | SK DIČ (only in Slovakia, does not start with country code) |
| **unreliable** | bool | Unreliable VAT-payer |
| **unreliable_checked_at** | DateTime? | Date of last check for unreliable VAT-payer |
| **legal_form** | string | Legal form |
| **vat_mode** | string | VAT mode |
| **bank_account** | string | Bank account number |
| **iban** | string | IBAN |
| **swift_bic** | string | SWIFT/BIC |
| **variable_symbol** | string | Fixed variable symbol (used for all invoices for this client instead of invoice number) |
| **setting_update_from_ares** | string | Whether to update subject data from ARES. Used to override account settings. Values: inherit, on, off. Default: inherit |
| **ares_update** | bool | Whether to update subject data from ARES. Used to override account settings. Default: true. Deprecated in favor of setting_update_from_ares |
| **setting_invoice_pdf_attachments** | string | Whether to attach invoice PDF in email. Used to override account settings. Values: inherit, on, off. Default: inherit |
| **setting_estimate_pdf_attachments** | string | Whether to attach estimate PDF in email. Used to override account settings. Values: inherit, on, off. Default: inherit |
| **setting_invoice_send_reminders** | string | Whether to send overdue invoice email reminders. Used to override account settings. Values: inherit, on, off. Default: inherit |
| **suggestion_enabled** | bool | Suggest for documents. Default: true |
| **custom_email_text** | string | New invoice custom email text |
| **overdue_email_text** | string | Overdue reminder custom email text |
| **invoice_from_proforma_email_text** | string | Proforma paid custom email text |
| **thank_you_email_text** | string | Thanks for payment custom email text |
| **custom_estimate_email_text** | string | Estimate custom email text |
| **webinvoice_history** | string | Webinvoice history. Values: null, "disabled", "recent", "client_portal". Default: null (inherit from account settings) |
| **html_url** | string | Subject HTML web address |
| **url** | string | Subject API address |
| **created_at** | DateTime | Date and time of subject creation |
| **updated_at** | DateTime | Date and time of last subject update |
# JsonTodo Class

Namespace: Altairis.Fakturoid.Client

Represents a todo task, as received from JSON API.

## Properties

| Name | Type | Summary |
|---|---|---|
| **name** | string | Typ události - initial_todo, initial_fb, already_paid, unpaired_payment, email_bounced |
| **created_at** | DateTime | Datum a čas vytvoření události |
| **completed_at** | DateTime? | Datum a čas odškrtnutí události |
| **invoice_id** | int? | ID faktury |
| **subject_id** | int? | ID kontaktu |
| **text** | string | Text události |
| **invoice_url** | string | API adresa faktury |
| **subject_url** | string | API adresa kontaktu |
# JsonUser Class

Namespace: Altairis.Fakturoid.Client

Represents a user associated with the event.

## Properties

| Name | Type | Summary |
|---|---|---|
| **Id** | int | User ID |
| **FullName** | string | Full user name |
| **Avatar** | string | Avatar URL |
# MyHttpClientExtensions Class

Namespace: Altairis.Fakturoid.Client


## Methods

| Name | Returns | Summary |
|---|---|---|
| [**FakturoidPatchAsJsonAsync(HttpClient client, string requestUri, T value)**](#fakturoidpatchasjsonasynchttpclient-client-string-requesturi-t-value) | Task\<HttpResponseMessage\> |  |
| [**FakturoidPostAsJsonAsync(HttpClient client, string requestUri, T value)**](#fakturoidpostasjsonasynchttpclient-client-string-requesturi-t-value) | Task\<HttpResponseMessage\> |  |
| [**FakturoidReadAsAsync(HttpContent content)**](#fakturoidreadasasynchttpcontent-content) | Task\<T\> |  |
## Methods

### FakturoidPatchAsJsonAsync(HttpClient client, string requestUri, T value)




### Returns

Task<HttpResponseMessage>


### FakturoidPostAsJsonAsync(HttpClient client, string requestUri, T value)




### Returns

Task<HttpResponseMessage>


### FakturoidReadAsAsync(HttpContent content)




### Returns

Task<T>


