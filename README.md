# 2022RestfullAPIApp
Nessessary Tools
1) I used postman to test the different CRUD operations for the rest API (Create,Read,Update,Delete) 
but for postman select post to add a record, and Patch to edit a record.
2) Visual studio 2020 or another viable IDE
3) SQl server 2019

Instructions:
1)Run database
2)Open the file with your IDE and run it
3)Open Postman 
(https://localhost:44343/api/job)
(https://localhost:44343/api/Applicants)
(https://localhost:44343/api/Applicants/Guid)
a)Select Get in the dropdown next to the URL of your server to get all records (see examples above)
b)Select Get in the dropdown next to the URL of your server with the Guid that you want to search by to find a specific record.
c)Select Post in the dropdown next to the URL of your server, select body and JSON below the URL. Then enter the information and click send to add record eg for applicant:
{
    "Name" : "Edit 1",
    "jobId": "f91c2ece-6461-4ea3-91bb-6cfcc5ebd607"
    
}
d)Select Patch in the dropdown next to the URL of your server with the Guid that you want to Edit then edit like is see above.
e)Select Delete in the dropdown next to the URL of your server with the Guid that you want to Delete then click send.
