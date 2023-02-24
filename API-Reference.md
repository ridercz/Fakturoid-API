# Altairis.Fakturoid.Client.dll v.2.11.0.0 API documentation

# All types

|   |   |   |
|---|---|---|
| [ExpensePaymentStatus Enum](#expensepaymentstatus-enum) | [GetCustomHttpClient Class](#getcustomhttpclient-class) | [JsonEvent Class](#jsonevent-class) |
| [ExpenseStatusCondition Enum](#expensestatuscondition-enum) | [InternalExtensionMethods Class](#internalextensionmethods-class) | [JsonExpense Class](#jsonexpense-class) |
| [FakturoidBankAccountsProxy Class](#fakturoidbankaccountsproxy-class) | [InvoiceMessageType Enum](#invoicemessagetype-enum) | [JsonExpenseLine Class](#jsonexpenseline-class) |
| [FakturoidContext Class](#fakturoidcontext-class) | [InvoicePaymentStatus Enum](#invoicepaymentstatus-enum) | [JsonInvoice Class](#jsoninvoice-class) |
| [FakturoidEntityProxy Class](#fakturoidentityproxy-class) | [InvoiceStatusCondition Enum](#invoicestatuscondition-enum) | [JsonInvoiceLine Class](#jsoninvoiceline-class) |
| [FakturoidEventsProxy Class](#fakturoideventsproxy-class) | [InvoiceTypeCondition Enum](#invoicetypecondition-enum) | [JsonSubject Class](#jsonsubject-class) |
| [FakturoidException Class](#fakturoidexception-class) | [JsonAccount Class](#jsonaccount-class) | [JsonTodo Class](#jsontodo-class) |
| [FakturoidExpensesProxy Class](#fakturoidexpensesproxy-class) | [JsonAttachment Class](#jsonattachment-class) | [AllowNullAttribute Class](#allownullattribute-class) |
| [FakturoidInvoicesProxy Class](#fakturoidinvoicesproxy-class) | [JsonBankAccount Class](#jsonbankaccount-class) | [NotNullWhenAttribute Class](#notnullwhenattribute-class) |
| [FakturoidSubjectsProxy Class](#fakturoidsubjectsproxy-class) | [JsonEet Class](#jsoneet-class) |   |
| [FakturoidTodosProxy Class](#fakturoidtodosproxy-class) | [JsonEntityLine Class](#jsonentityline-class) |   |
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
| [**Select()**](#select) | IEnumerable\<[JsonBankAccount](#jsonbankaccount-class)\> | Gets list of all bank accounts. |
| [**SelectAsync()**](#selectasync) | Task\<IEnumerable\<[JsonBankAccount](#jsonbankaccount-class)\>\> | Gets asynchronously list of all bank accounts. |
## Methods

### Select()

Gets list of all bank accounts.



### Returns

IEnumerable<[JsonBankAccount](#jsonbankaccount-class)>

List of **Altairis.Fakturoid.Client.JsonBankAccount** instances.

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
| **EmailAddress** | string | Gets the Fakturoid account email address. |
| **AuthenticationToken** | string | Gets the Fakturoid authentication token. |
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
| [**FakturoidContext(string accountName, string emailAddress, string authenticationToken, string userAgent, GetCustomHttpClient getCustomHttpClient)**](#fakturoidcontextstring-accountname-string-emailaddress-string-authenticationtoken-string-useragent-getcustomhttpclient-getcustomhttpclient) | Initializes a new instance of the **Altairis.Fakturoid.Client.FakturoidContext** class. |
## Methods

| Name | Returns | Summary |
|---|---|---|
| [**GetAccountInfo()**](#getaccountinfo) | [JsonAccount](#jsonaccount-class) | Gets the account information. |
## Constructors

### FakturoidContext(string accountName, string emailAddress, string authenticationToken, string userAgent, GetCustomHttpClient getCustomHttpClient)

Initializes a new instance of the **Altairis.Fakturoid.Client.FakturoidContext** class.

| Parameter | Type | Description |
|---|---|---|
| accountName | string | Account name (accountName). |
| emailAddress | string | The email address od user being authenticated. |
| authenticationToken | string | The authentication token. |
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
| [**Select(DateTime? since)**](#selectdatetime-since) | IEnumerable\<[JsonEvent](#jsonevent-class)\> | Gets list of all current events. |
| [**Select(int page, DateTime? since)**](#selectint-page-datetime-since) | IEnumerable\<[JsonEvent](#jsonevent-class)\> | Gets list of current events, paged by 15. |
| [**SelectAsync(DateTime? since)**](#selectasyncdatetime-since) | Task\<IEnumerable\<[JsonEvent](#jsonevent-class)\>\> | Gets asynchronously list of all current events. |
| [**SelectAsync(int page, DateTime? since)**](#selectasyncint-page-datetime-since) | Task\<IEnumerable\<[JsonEvent](#jsonevent-class)\>\> | Gets asynchronously list of current events, paged by 15. |
## Methods

### Select(DateTime? since)

Gets list of all current events.

| Parameter | Type | Description |
|---|---|---|
| since | DateTime? | The date since when events are to be selected. |


### Returns

IEnumerable<[JsonEvent](#jsonevent-class)>

List of **Altairis.Fakturoid.Client.JsonEvent** instances.

### Select(int page, DateTime? since)

Gets list of current events, paged by 15.

| Parameter | Type | Description |
|---|---|---|
| page | int | The page number. |
| since | DateTime? | The date since when events are to be selected. |


### Returns

IEnumerable<[JsonEvent](#jsonevent-class)>

List of **Altairis.Fakturoid.Client.JsonEvent** instances.

### SelectAsync(DateTime? since)

Gets asynchronously list of all current events.

| Parameter | Type | Description |
|---|---|---|
| since | DateTime? | The date since when events are to be selected. |


### Returns

Task<IEnumerable<[JsonEvent](#jsonevent-class)>>

List of **Altairis.Fakturoid.Client.JsonEvent** instances.

### SelectAsync(int page, DateTime? since)

Gets asynchronously list of current events, paged by 15.

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
| [**Create(JsonExpense entity)**](#createjsonexpense-entity) | int | Creates the specified new expense. |
| [**CreateAsync(JsonExpense entity)**](#createasyncjsonexpense-entity) | Task\<int\> | Creates asynchronously the specified new expense. |
| [**Delete(int id)**](#deleteint-id) | void | Deletes expense with specified id. |
| [**DeleteAsync(int id)**](#deleteasyncint-id) | Task | Deletes asynchronously expense with specified id. |
| [**Select(ExpenseStatusCondition status, int? subjectId, DateTime? since, string number)**](#selectexpensestatuscondition-status-int-subjectid-datetime-since-string-number) | IEnumerable\<[JsonExpense](#jsonexpense-class)\> | Gets list of all invoices. |
| [**Select(int page, ExpenseStatusCondition status, int? subjectId, DateTime? since, string number)**](#selectint-page-expensestatuscondition-status-int-subjectid-datetime-since-string-number) | IEnumerable\<[JsonExpense](#jsonexpense-class)\> | Gets paged list of invoices. |
| [**SelectAsync(ExpenseStatusCondition status, int? subjectId, DateTime? since, string number)**](#selectasyncexpensestatuscondition-status-int-subjectid-datetime-since-string-number) | Task\<IEnumerable\<[JsonExpense](#jsonexpense-class)\>\> | Gets asynchronously list of all invoices. |
| [**SelectAsync(int page, ExpenseStatusCondition status, int? subjectId, DateTime? since, string number)**](#selectasyncint-page-expensestatuscondition-status-int-subjectid-datetime-since-string-number) | Task\<IEnumerable\<[JsonExpense](#jsonexpense-class)\>\> | Gets asynchronously paged list of invoices. |
| [**SelectSingle(int id)**](#selectsingleint-id) | [JsonExpense](#jsonexpense-class) | Selects single expense with specified ID. |
| [**SelectSingleAsync(int id)**](#selectsingleasyncint-id) | Task\<[JsonExpense](#jsonexpense-class)\> | Selects asynchronously single expense with specified ID. |
| [**SetAttachment(int id, string filePath)**](#setattachmentint-id-string-filepath) | void | Sets attachment for invoice. |
| [**SetAttachment(int id, string mimeType, byte[] fileContent)**](#setattachmentint-id-string-mimetype-byte-filecontent) | void | Sets attachment for invoice. |
| [**SetAttachmentAsync(int id, string filePath)**](#setattachmentasyncint-id-string-filepath) | Task | Sets attachment for invoice. |
| [**SetAttachmentAsync(int id, string mimeType, byte[] fileContent)**](#setattachmentasyncint-id-string-mimetype-byte-filecontent) | Task | Sets attachment for invoice. |
| [**SetPaymentStatus(int id, ExpensePaymentStatus status)**](#setpaymentstatusint-id-expensepaymentstatus-status) | void | Sets the expense payment status. |
| [**SetPaymentStatus(int id, ExpensePaymentStatus status, DateTime effectiveDate)**](#setpaymentstatusint-id-expensepaymentstatus-status-datetime-effectivedate) | void | Sets the expense payment status. |
| [**SetPaymentStatusAsync(int id, ExpensePaymentStatus status)**](#setpaymentstatusasyncint-id-expensepaymentstatus-status) | Task | Sets asynchronously the expense payment status. |
| [**SetPaymentStatusAsync(int id, ExpensePaymentStatus status, DateTime effectiveDate)**](#setpaymentstatusasyncint-id-expensepaymentstatus-status-datetime-effectivedate) | Task | Sets asynchronously the expense payment status. |
| [**Update(JsonExpense entity)**](#updatejsonexpense-entity) | [JsonExpense](#jsonexpense-class) | Updates the specified expense. |
| [**UpdateAsync(JsonExpense entity)**](#updateasyncjsonexpense-entity) | Task\<[JsonExpense](#jsonexpense-class)\> | Updates asynchronously the specified expense. |
## Methods

### Create(JsonExpense entity)

Creates the specified new expense.

| Parameter | Type | Description |
|---|---|---|
| entity | [JsonExpense](#jsonexpense-class) | The new expense. |


### Returns

int

ID of newly created expense.

### CreateAsync(JsonExpense entity)

Creates asynchronously the specified new expense.

| Parameter | Type | Description |
|---|---|---|
| entity | [JsonExpense](#jsonexpense-class) | The new expense. |


### Returns

Task<int>

ID of newly created expense.

### Delete(int id)

Deletes expense with specified id.

| Parameter | Type | Description |
|---|---|---|
| id | int | The contact id. |


### DeleteAsync(int id)

Deletes asynchronously expense with specified id.

| Parameter | Type | Description |
|---|---|---|
| id | int | The contact id. |


### Returns

Task



### Select(ExpenseStatusCondition status, int? subjectId, DateTime? since, string number)

Gets list of all invoices.

| Parameter | Type | Description |
|---|---|---|
| status | [ExpenseStatusCondition](#expensestatuscondition-enum) | The expense status. |
| subjectId | int? | The customer subject id. |
| since | DateTime? | The date since when the expense was created. |
| number | string | The expense display number. |


### Returns

IEnumerable<[JsonExpense](#jsonexpense-class)>

List of **Altairis.Fakturoid.Client.JsonExpense** instances.

### Select(int page, ExpenseStatusCondition status, int? subjectId, DateTime? since, string number)

Gets paged list of invoices.

| Parameter | Type | Description |
|---|---|---|
| page | int | The page number. |
| status | [ExpenseStatusCondition](#expensestatuscondition-enum) | The expense status. |
| subjectId | int? | The customer subject id. |
| since | DateTime? | The date since when the expense was created. |
| number | string | The expense display number. |


### Returns

IEnumerable<[JsonExpense](#jsonexpense-class)>

List of **Altairis.Fakturoid.Client.JsonExpense** instances.

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

### SelectSingle(int id)

Selects single expense with specified ID.

| Parameter | Type | Description |
|---|---|---|
| id | int | The expense id. |


### Returns

[JsonExpense](#jsonexpense-class)

Instance of **Altairis.Fakturoid.Client.JsonExpense** class.

### SelectSingleAsync(int id)

Selects asynchronously single expense with specified ID.

| Parameter | Type | Description |
|---|---|---|
| id | int | The expense id. |


### Returns

Task<[JsonExpense](#jsonexpense-class)>

Instance of **Altairis.Fakturoid.Client.JsonExpense** class.

### SetAttachment(int id, string filePath)

Sets attachment for invoice.

| Parameter | Type | Description |
|---|---|---|
| id | int | The invoice id. |
| filePath | string | The file path. |


### SetAttachment(int id, string mimeType, byte[] fileContent)

Sets attachment for invoice.

| Parameter | Type | Description |
|---|---|---|
| id | int | The invoice id. |
| mimeType | string | The mime type. |
| fileContent | byte[] | The content of the file. |


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



### SetPaymentStatus(int id, ExpensePaymentStatus status)

Sets the expense payment status.

| Parameter | Type | Description |
|---|---|---|
| id | int | The expense id. |
| status | [ExpensePaymentStatus](#expensepaymentstatus-enum) | The new payment status. |


### SetPaymentStatus(int id, ExpensePaymentStatus status, DateTime effectiveDate)

Sets the expense payment status.

| Parameter | Type | Description |
|---|---|---|
| id | int | The expense id. |
| status | [ExpensePaymentStatus](#expensepaymentstatus-enum) | The new payment status. |
| effectiveDate | DateTime | The date when payment was performed. |


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



### Update(JsonExpense entity)

Updates the specified expense.

| Parameter | Type | Description |
|---|---|---|
| entity | [JsonExpense](#jsonexpense-class) | The expense to update. |


### Returns

[JsonExpense](#jsonexpense-class)

Instance of **Altairis.Fakturoid.Client.JsonExpense** class with modified entity.

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
| [**Create(JsonInvoice entity)**](#createjsoninvoice-entity) | int | Creates the specified new invoice. |
| [**CreateAsync(JsonInvoice entity)**](#createasyncjsoninvoice-entity) | Task\<int\> | Creates asynchronously the specified new invoice. |
| [**Delete(int id)**](#deleteint-id) | void | Deletes invoice with specified id. |
| [**DeleteAsync(int id)**](#deleteasyncint-id) | Task | Deletes asynchronously invoice with specified id. |
| [**Select(InvoiceTypeCondition type, InvoiceStatusCondition status, int? subjectId, DateTime? since, string number)**](#selectinvoicetypecondition-type-invoicestatuscondition-status-int-subjectid-datetime-since-string-number) | IEnumerable\<[JsonInvoice](#jsoninvoice-class)\> | Gets list of all invoices. |
| [**Select(int page, InvoiceTypeCondition type, InvoiceStatusCondition status, int? subjectId, DateTime? since, string number)**](#selectint-page-invoicetypecondition-type-invoicestatuscondition-status-int-subjectid-datetime-since-string-number) | IEnumerable\<[JsonInvoice](#jsoninvoice-class)\> | Gets paged list of invoices. |
| [**SelectAsync(InvoiceTypeCondition type, InvoiceStatusCondition status, int? subjectId, DateTime? since, string number)**](#selectasyncinvoicetypecondition-type-invoicestatuscondition-status-int-subjectid-datetime-since-string-number) | Task\<IEnumerable\<[JsonInvoice](#jsoninvoice-class)\>\> | Gets asynchronously list of all invoices. |
| [**SelectAsync(int page, InvoiceTypeCondition type, InvoiceStatusCondition status, int? subjectId, DateTime? since, string number)**](#selectasyncint-page-invoicetypecondition-type-invoicestatuscondition-status-int-subjectid-datetime-since-string-number) | Task\<IEnumerable\<[JsonInvoice](#jsoninvoice-class)\>\> | Gets asynchronously paged list of invoices. |
| [**SelectSingle(int id)**](#selectsingleint-id) | [JsonInvoice](#jsoninvoice-class) | Selects single invoice with specified ID. |
| [**SelectSingleAsync(int id)**](#selectsingleasyncint-id) | Task\<[JsonInvoice](#jsoninvoice-class)\> | Selects asynchronously single invoice with specified ID. |
| [**SendMessage(int id, InvoiceMessageType messageType)**](#sendmessageint-id-invoicemessagetype-messagetype) | void | Sends e-mail message for the specified invoice. |
| [**SendMessageAsync(int id, InvoiceMessageType messageType)**](#sendmessageasyncint-id-invoicemessagetype-messagetype) | Task | Sends asynchronously e-mail message for the specified invoice. |
| [**SetAttachment(int id, string filePath)**](#setattachmentint-id-string-filepath) | void | Sets attachment for invoice. |
| [**SetAttachment(int id, string mimeType, byte[] fileContent)**](#setattachmentint-id-string-mimetype-byte-filecontent) | void | Sets attachment for invoice. |
| [**SetAttachmentAsync(int id, string filePath)**](#setattachmentasyncint-id-string-filepath) | Task | Sets attachment for invoice. |
| [**SetAttachmentAsync(int id, string mimeType, byte[] fileContent)**](#setattachmentasyncint-id-string-mimetype-byte-filecontent) | Task | Sets attachment for invoice. |
| [**SetPaymentStatus(int id, InvoicePaymentStatus status)**](#setpaymentstatusint-id-invoicepaymentstatus-status) | void | Sets the invoice payment status. |
| [**SetPaymentStatus(int id, InvoicePaymentStatus status, DateTime effectiveDate)**](#setpaymentstatusint-id-invoicepaymentstatus-status-datetime-effectivedate) | void | Sets the invoice payment status. |
| [**SetPaymentStatusAsync(int id, InvoicePaymentStatus status)**](#setpaymentstatusasyncint-id-invoicepaymentstatus-status) | Task | Sets asynchronously the invoice payment status. |
| [**SetPaymentStatusAsync(int id, InvoicePaymentStatus status, DateTime effectiveDate)**](#setpaymentstatusasyncint-id-invoicepaymentstatus-status-datetime-effectivedate) | Task | Sets asynchronously the invoice payment status. |
| [**Update(JsonInvoice entity)**](#updatejsoninvoice-entity) | [JsonInvoice](#jsoninvoice-class) | Updates the specified invoice. |
| [**UpdateAsync(JsonInvoice entity)**](#updateasyncjsoninvoice-entity) | Task\<[JsonInvoice](#jsoninvoice-class)\> | Updates asynchronously the specified invoice. |
## Methods

### Create(JsonInvoice entity)

Creates the specified new invoice.

| Parameter | Type | Description |
|---|---|---|
| entity | [JsonInvoice](#jsoninvoice-class) | The new invoice. |


### Returns

int

ID of newly created invoice.

### CreateAsync(JsonInvoice entity)

Creates asynchronously the specified new invoice.

| Parameter | Type | Description |
|---|---|---|
| entity | [JsonInvoice](#jsoninvoice-class) | The new invoice. |


### Returns

Task<int>

ID of newly created invoice.

### Delete(int id)

Deletes invoice with specified id.

| Parameter | Type | Description |
|---|---|---|
| id | int | The contact id. |


### DeleteAsync(int id)

Deletes asynchronously invoice with specified id.

| Parameter | Type | Description |
|---|---|---|
| id | int | The contact id. |


### Returns

Task



### Select(InvoiceTypeCondition type, InvoiceStatusCondition status, int? subjectId, DateTime? since, string number)

Gets list of all invoices.

| Parameter | Type | Description |
|---|---|---|
| type | [InvoiceTypeCondition](#invoicetypecondition-enum) | The invoice type. |
| status | [InvoiceStatusCondition](#invoicestatuscondition-enum) | The invoice status. |
| subjectId | int? | The customer subject id. |
| since | DateTime? | The date since when the invoice was created. |
| number | string | The invoice display number. |


### Returns

IEnumerable<[JsonInvoice](#jsoninvoice-class)>

List of **Altairis.Fakturoid.Client.JsonInvoice** instances.

### Select(int page, InvoiceTypeCondition type, InvoiceStatusCondition status, int? subjectId, DateTime? since, string number)

Gets paged list of invoices.

| Parameter | Type | Description |
|---|---|---|
| page | int | The page number. |
| type | [InvoiceTypeCondition](#invoicetypecondition-enum) | The invoice type. |
| status | [InvoiceStatusCondition](#invoicestatuscondition-enum) | The invoice status. |
| subjectId | int? | The customer subject id. |
| since | DateTime? | The date since when the invoice was created. |
| number | string | The invoice display number. |


### Returns

IEnumerable<[JsonInvoice](#jsoninvoice-class)>

List of **Altairis.Fakturoid.Client.JsonInvoice** instances.

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

### SelectSingle(int id)

Selects single invoice with specified ID.

| Parameter | Type | Description |
|---|---|---|
| id | int | The invoice id. |


### Returns

[JsonInvoice](#jsoninvoice-class)

Instance of **Altairis.Fakturoid.Client.JsonInvoice** class.

### SelectSingleAsync(int id)

Selects asynchronously single invoice with specified ID.

| Parameter | Type | Description |
|---|---|---|
| id | int | The invoice id. |


### Returns

Task<[JsonInvoice](#jsoninvoice-class)>

Instance of **Altairis.Fakturoid.Client.JsonInvoice** class.

### SendMessage(int id, InvoiceMessageType messageType)

Sends e-mail message for the specified invoice.

| Parameter | Type | Description |
|---|---|---|
| id | int | The invoice id. |
| messageType | [InvoiceMessageType](#invoicemessagetype-enum) | Type of the message. |


### SendMessageAsync(int id, InvoiceMessageType messageType)

Sends asynchronously e-mail message for the specified invoice.

| Parameter | Type | Description |
|---|---|---|
| id | int | The invoice id. |
| messageType | [InvoiceMessageType](#invoicemessagetype-enum) | Type of the message. |


### Returns

Task



### SetAttachment(int id, string filePath)

Sets attachment for invoice.

| Parameter | Type | Description |
|---|---|---|
| id | int | The invoice id. |
| filePath | string | The file path. |


### SetAttachment(int id, string mimeType, byte[] fileContent)

Sets attachment for invoice.

| Parameter | Type | Description |
|---|---|---|
| id | int | The invoice id. |
| mimeType | string | The mime type. |
| fileContent | byte[] | The content of the file. |


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



### SetPaymentStatus(int id, InvoicePaymentStatus status)

Sets the invoice payment status.

| Parameter | Type | Description |
|---|---|---|
| id | int | The invoice id. |
| status | [InvoicePaymentStatus](#invoicepaymentstatus-enum) | The new payment status. |


### SetPaymentStatus(int id, InvoicePaymentStatus status, DateTime effectiveDate)

Sets the invoice payment status.

| Parameter | Type | Description |
|---|---|---|
| id | int | The invoice id. |
| status | [InvoicePaymentStatus](#invoicepaymentstatus-enum) | The new payment status. |
| effectiveDate | DateTime | The date when payment was performed. |


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



### Update(JsonInvoice entity)

Updates the specified invoice.

| Parameter | Type | Description |
|---|---|---|
| entity | [JsonInvoice](#jsoninvoice-class) | The invoice to update. |


### Returns

[JsonInvoice](#jsoninvoice-class)

Instance of **Altairis.Fakturoid.Client.JsonInvoice** class with modified entity.

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
| [**Create(JsonSubject entity)**](#createjsonsubject-entity) | int | Creates the specified new subject. |
| [**CreateAsync(JsonSubject entity)**](#createasyncjsonsubject-entity) | Task\<int\> | Creates asynchronously the specified new subject. |
| [**Delete(int id)**](#deleteint-id) | void | Deletes subject with specified id. |
| [**DeleteAsync(int id)**](#deleteasyncint-id) | Task | Deletes asynchronously with specified id. |
| [**Search(string searchTerm)**](#searchstring-searchterm) | IEnumerable\<[JsonSubject](#jsonsubject-class)\> | Searches all Subjects in Name, Full name, Email, Registration number and Country. |
| [**SearchAsync(string searchTerm)**](#searchasyncstring-searchterm) | Task\<IEnumerable\<[JsonSubject](#jsonsubject-class)\>\> | Searches asynchronously all Subjects in Name, Full name, Email, Registration number and Country. |
| [**Select(string customId)**](#selectstring-customid) | IEnumerable\<[JsonSubject](#jsonsubject-class)\> | Gets list of all subjects. |
| [**Select(int page)**](#selectint-page) | IEnumerable\<[JsonSubject](#jsonsubject-class)\> | Gets paged list of subjects |
| [**SelectAsync(int page)**](#selectasyncint-page) | Task\<IEnumerable\<[JsonSubject](#jsonsubject-class)\>\> | Gets asynchronously paged list of subjects |
| [**SelectAsync(string customId, DateTime? updatedSince)**](#selectasyncstring-customid-datetime-updatedsince) | Task\<IEnumerable\<[JsonSubject](#jsonsubject-class)\>\> | Gets asynchronously list of all subjects. |
| [**SelectSingle(int id)**](#selectsingleint-id) | [JsonSubject](#jsonsubject-class) | Selects single subject with specified ID. |
| [**SelectSingleAsync(int id)**](#selectsingleasyncint-id) | Task\<[JsonSubject](#jsonsubject-class)\> | Selects asynchronously single subject with specified ID. |
| [**Update(JsonSubject entity)**](#updatejsonsubject-entity) | [JsonSubject](#jsonsubject-class) | Updates the specified subject. |
| [**UpdateAsync(JsonSubject entity)**](#updateasyncjsonsubject-entity) | Task\<[JsonSubject](#jsonsubject-class)\> | Updates asynchronously the specified subject. |
## Methods

### Create(JsonSubject entity)

Creates the specified new subject.

| Parameter | Type | Description |
|---|---|---|
| entity | [JsonSubject](#jsonsubject-class) | The new subject. |


### Returns

int

ID of newly created subject.

### CreateAsync(JsonSubject entity)

Creates asynchronously the specified new subject.

| Parameter | Type | Description |
|---|---|---|
| entity | [JsonSubject](#jsonsubject-class) | The new subject. |


### Returns

Task<int>

ID of newly created subject.

### Delete(int id)

Deletes subject with specified id.

| Parameter | Type | Description |
|---|---|---|
| id | int | The contact id. |


### DeleteAsync(int id)

Deletes asynchronously with specified id.

| Parameter | Type | Description |
|---|---|---|
| id | int | The contact id. |


### Returns

Task



### Search(string searchTerm)

Searches all Subjects in Name, Full name, Email, Registration number and Country.

| Parameter | Type | Description |
|---|---|---|
| searchTerm | string | Search string. |


### Returns

IEnumerable<[JsonSubject](#jsonsubject-class)>

Collection if search results.

### SearchAsync(string searchTerm)

Searches asynchronously all Subjects in Name, Full name, Email, Registration number and Country.

| Parameter | Type | Description |
|---|---|---|
| searchTerm | string | Search string. |


### Returns

Task<IEnumerable<[JsonSubject](#jsonsubject-class)>>

Collection if search results.

### Select(string customId)

Gets list of all subjects.

| Parameter | Type | Description |
|---|---|---|
| customId | string | The custom identifier used for filtering. |


### Returns

IEnumerable<[JsonSubject](#jsonsubject-class)>

List of **Altairis.Fakturoid.Client.JsonSubject** instances.

### Select(int page)

Gets paged list of subjects

| Parameter | Type | Description |
|---|---|---|
| page | int | The page number. |


### Returns

IEnumerable<[JsonSubject](#jsonsubject-class)>

List of **Altairis.Fakturoid.Client.JsonSubject** instances.

### SelectAsync(int page)

Gets asynchronously paged list of subjects

| Parameter | Type | Description |
|---|---|---|
| page | int | The page number. |


### Returns

Task<IEnumerable<[JsonSubject](#jsonsubject-class)>>

List of **Altairis.Fakturoid.Client.JsonSubject** instances.

### SelectAsync(string customId, DateTime? updatedSince)

Gets asynchronously list of all subjects.

| Parameter | Type | Description |
|---|---|---|
| customId | string | The custom identifier used for filtering. |
| updatedSince | DateTime? | List only subjects updated since certain date. |


### Returns

Task<IEnumerable<[JsonSubject](#jsonsubject-class)>>

List of **Altairis.Fakturoid.Client.JsonSubject** instances.

### SelectSingle(int id)

Selects single subject with specified ID.

| Parameter | Type | Description |
|---|---|---|
| id | int | The subject id. |


### Returns

[JsonSubject](#jsonsubject-class)

Instance of **Altairis.Fakturoid.Client.JsonSubject** class.

### SelectSingleAsync(int id)

Selects asynchronously single subject with specified ID.

| Parameter | Type | Description |
|---|---|---|
| id | int | The subject id. |


### Returns

Task<[JsonSubject](#jsonsubject-class)>

Instance of **Altairis.Fakturoid.Client.JsonSubject** class.

### Update(JsonSubject entity)

Updates the specified subject.

| Parameter | Type | Description |
|---|---|---|
| entity | [JsonSubject](#jsonsubject-class) | The subject to update. |


### Returns

[JsonSubject](#jsonsubject-class)

Instance of **Altairis.Fakturoid.Client.JsonSubject** class with modified entity.

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
| [**Select(DateTime? since)**](#selectdatetime-since) | IEnumerable\<[JsonTodo](#jsontodo-class)\> | Gets list of all current todos. |
| [**Select(int page, DateTime? since)**](#selectint-page-datetime-since) | IEnumerable\<[JsonTodo](#jsontodo-class)\> | Gets paged list of current todos |
| [**SelectAsync(DateTime? since)**](#selectasyncdatetime-since) | Task\<IEnumerable\<[JsonTodo](#jsontodo-class)\>\> | Gets asynchronously list of all current todos. |
| [**SelectAsync(int page, DateTime? since)**](#selectasyncint-page-datetime-since) | Task\<IEnumerable\<[JsonTodo](#jsontodo-class)\>\> | Gets asynchronously paged list of current todos |
## Methods

### Select(DateTime? since)

Gets list of all current todos.

| Parameter | Type | Description |
|---|---|---|
| since | DateTime? | The date since when todos are to be selected. |


### Returns

IEnumerable<[JsonTodo](#jsontodo-class)>

List of **Altairis.Fakturoid.Client.JsonTodo** instances.

### Select(int page, DateTime? since)

Gets paged list of current todos

| Parameter | Type | Description |
|---|---|---|
| page | int | The page number. |
| since | DateTime? | The date since when todos are to be selected. |


### Returns

IEnumerable<[JsonTodo](#jsontodo-class)>

List of **Altairis.Fakturoid.Client.JsonTodo** instances.

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
# JsonAccount Class

Namespace: Altairis.Fakturoid.Client

User account information, as received from JSON API.

## Properties

| Name | Type | Summary |
|---|---|---|
| **subdomain** | string | Subdoména |
| **plan** | string | Jméno tarifu |
| **plan_price** | int | Cena tarifu |
| **email** | string | E-mail vlastníka účtu |
| **invoice_email** | string | E-mail, ze kterého jsou odesílány faktury |
| **phone** | string | Telefon vlastníka účtu |
| **web** | string | Web vlastníka účtu |
| **name** | string | Jméno firmy |
| **full_name** | string | Jméno majitele účtu |
| **registration_no** | string | IČ |
| **vat_no** | string | DIČ |
| **vat_mode** | string | Plátce DPH / Neplátce DPH / Identifikovaná osoba |
| **street** | string | Ulice |
| **street2** | string | Ulice - druhý řádek |
| **city** | string | Místo |
| **zip** | string | PSČ |
| **country** | string | ISO kód země |
| **bank_account** | string | Číslo účtu |
| **iban** | string | Číslo účtu jako IBAN |
| **swift_bic** | string | BIC (pro SWIFT platby) |
| **currency** | string | Měna |
| **unit_name** | string | Výchozí měrná jednotka |
| **vat_rate** | decimal | Výchozí sazba DPH |
| **displayed_note** | string | Text patičky faktury |
| **invoice_note** | string | Text před položkami faktury |
| **due** | int | Výchozí splatnost faktur |
| **custom_email_text** | string | Text emailu pro odeslání faktury |
| **overdue_email_text** | string | Text upomínky o zaplacení |
| **html_url** | string | Adresa účtu v GUI |
| **url** | string | Adresa API |
| **updated_at** | DateTime | Datum poslední úpravy účtu |
| **created_at** | DateTime | Datum vytvoření účtu |
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
| **id** | int | Identifikátor bankovního účtu |
| **name** | string | Název účtu |
| **currency** | string | Měna účtu |
| **number** | string | Číslo účtu |
| **iban** | string | Číslo účtu ve formátu IBAN |
| **swift_bic** | string | BIC pro SWIFT platby |
| **pairing** | bool | Povoleno párování plateb |
| **payment_adjustment** | bool | Haléřové vyrovnání pro párování plateb |
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
| **name** | string | Typ události - generated, sent, accepted, sent_reminder, overdue, paid, paid_bank, payment_removed, unpaired_payment |
| **created_at** | DateTime | Datum a čas vytvoření události |
| **invoice_id** | int? | ID faktury (nepovinné) |
| **subject_id** | int? | ID kontaktu (nepovinné) |
| **text** | string | Text události |
| **invoice_url** | string | API adresa faktury (nepovinné) |
| **subject_url** | string | API adresa kontaktu (nepovinné) |
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
| **subject_custom_id** | int | identifikátor kontaktu ve vaší aplikaci - nepovinné |
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
# JsonSubject Class

Namespace: Altairis.Fakturoid.Client

Subject (contact), as received from JSON API.

## Properties

| Name | Type | Summary |
|---|---|---|
| **id** | int | Identifikátor kontaktu |
| **custom_id** | string | Vlastní identifikátor kontaktu |
| **name** | string | Obchodní jméno |
| **street** | string | Ulice |
| **street2** | string | Ulice - druhý řádek |
| **city** | string | Město |
| **zip** | string | PSČ |
| **country** | string | Země |
| **registration_no** | string | IČ |
| **vat_no** | string | DIČ |
| **bank_account** | string | Číslo účtu |
| **iban** | string | Číslo účtu jako IBAN |
| **variable_symbol** | string | Variabilní symbol |
| **full_name** | string | Jméno kontaktní osoby |
| **email** | string | E-mail pro zasílání faktur |
| **email_copy** | string | E-mail pro zasílání kopie faktury |
| **phone** | string | Telefonní číslo |
| **web** | string | Adresa webu |
| **avatar_url** | string | Adresa obrázku kontaktu |
| **html_url** | string | Adresa kontaktu v GUI |
| **url** | string | API adresa kontaktu |
| **updated_at** | DateTime | Datum poslední aktualizace kontaktu |
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
# AllowNullAttribute Class

Namespace: System.Diagnostics.CodeAnalysis

Base class: Attribute

Specifies that null is allowed as an input even if the corresponding type disallows it.

## Properties

| Name | Type | Summary |
|---|---|---|
| **TypeId** | Object |  |
# NotNullWhenAttribute Class

Namespace: System.Diagnostics.CodeAnalysis

Base class: Attribute

Specifies that when a method returns **System.Diagnostics.CodeAnalysis.NotNullWhenAttribute.ReturnValue**, the parameter will not be null even if the corresponding type allows it.

## Properties

| Name | Type | Summary |
|---|---|---|
| **ReturnValue** | bool | Gets the return value condition. |
| **TypeId** | Object |  |
## Constructors

| Name | Summary |
|---|---|
| [**NotNullWhenAttribute(bool returnValue)**](#notnullwhenattributebool-returnvalue) | Initializes the attribute with the specified return value condition. |
## Constructors

### NotNullWhenAttribute(bool returnValue)

Initializes the attribute with the specified return value condition.

| Parameter | Type | Description |
|---|---|---|
| returnValue | bool | The return value condition. If the method returns this value, the associated parameter will not be null. |


