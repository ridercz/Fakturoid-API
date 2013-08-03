Invoicing Import Application
============================

This application is the main reason why I wrote the client library. We're moving our accounting from home-grown system to Fakturoid. And I need to migrate the data from our system. That's exactly what this application does.

You would probably not find much use for this app, because if you're moving data from somewhere, you most certainly have quite different database structure than we have.

> **Do not use this app with your production Fakturoid account.** For starters, **it will delete all your current data**, invoices, contacts, everything.

You should also not take this application like example of coding style and so on. It has lots of things hardcoded, lacks exception handling... Because this kind of utility is supposed to be run just once to do its job and then be promptly forgotten.

I'm publishing the code so you can have some idea on how the client library is to be used in real environment. I hope it might be useful for someone.