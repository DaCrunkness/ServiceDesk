# ServiceDesk

A web application that serves as an automated service desk to facilitate with in house data transactions.

## Change title of program

ErrorSnuffer ?, maybe

## Current Objectives

Upload file to api
Read file into appropriate model
Send to database

## Next Phase

Update user profiles
Set user roles
Create stored procedures
Scan for new files/errors
Process new files
Create ticket
if ticket.AutoAssign = true send to entity else send to ticket pool
Send notification

# Test User JSON

```
{
"FirstName": "Jerell",
"LastName": "Smith",
"PhoneNumber": "4444444444",
"EmailAddress": "dev@smithovision.com",
"UsersGroup": "Tech"
}

{
"FirstName": "Brandon",
"LastName": "Cordon",
"PhoneNumber": "8888888888",
"EmailAddress": "bradon@cordon.com",
"UsersGroup": "Tech"
}

{
"FirstName": "Kelcie",
"LastName": "Bloom",
"PhoneNumber": "1111111111",
"EmailAddress": "kelcie@bloom.com",
"UsersGroup": "Tech"
}

{
"FirstName": "Lyle",
"LastName": "Mord",
"PhoneNumber": "3333333333",
"EmailAddress": "lyle@mord.com",
"UsersGroup": "Tech"
}

{
"FirstName": "System1",
"LastName": "FilePusher",
"PhoneNumber": "18005554444",
"EmailAddress": "s1@system.com",
"UsersGroup": "System"
}

{
"FirstName": "System2",
"LastName": "ErrorSwapper",
"PhoneNumber": "18007894563",
"EmailAddress": "s2@system.com",
"UsersGroup": "System"
}

```
