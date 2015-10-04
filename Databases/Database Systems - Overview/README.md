## Database Systems

1. What database models do you know?
    * Hierarchical(tree)
    * Network/Graph
    * Relational(table)
    * Object-oriented
2. Which are the main functions performed by a Relational Database Management System (RDBMS)?
    * Creating / Altering / Deleting tables and relationships between them
    * Adding / Changing / Deleting / Searching / Retrieving data stored in the tables.
    * Support for the SQL language
3. Define what is "table" in database terms.
    * Tables consist of data, arranged in rows and columns. 
        * All rows have the same structure.
        * All columns have name and type.
4. Explain the difference between a primary and a foreign key.
    * Primary key is a column in the table that uniquely identifies it's rows.
    * Foreign key is a field in one table that uniquely identifies a row of another table.
5. Explain the different kinds of relationships between tables in relational databases.
    * One-to-many: Each row in the related to table can be related to many rows in the relating table.
    * Many-to-many: One or more rows in a table can be related to 0, 1 or many rows in another table.
    * One-to-one: Each row in one database table is linked to 1 and only 1 other row in another table.
6. When is a certain database schema normalized? What are the advantages of normalized databases?
    * Normalization of database schema is the process of organizing the columns (attributes) and tables (relations) of a relational database to minimize data redundancy.
    * Advantages:
        * freeing the collection of relations from undesirable insertion, update and deletion dependencies;
        *  reducing the need for restructuring the collection of relations, as new types of data are introduced, and thus increase the life span of application programs;
        *  making the relational model more informative to users;
        *  making the collection of relations neutral to the query statistics, where these statistics are liable to change as time goes by.
7. What are database integrity constraints and when are they used?
    * Integrity constraints ensure data integrity in the database tables by enforcing data rules which cannot be violated.
        * Primary key constraint
        * Unique key constraint
        * Foreign key constraint
        * Check constraint
8. Point out the pros and cons of using indices in a database.
    * Pros:
        * Speed up searching for values in certain column or group of columns
    * Cons:
        * Adding, updating and deleting records in indexed tables is slower
9. What's the main purpose of the SQL language?
    * The Structured Query Language(SQL) is standardized declarative language for manipulation of relational databases. It's used to create, alter, delete tables and other objects from the database, as well as to search, retrieve, modify, insert and delete table data(rows).
10. What are transactions used for? Give an example.
    * Transactions are a sequence of database operations which are executed as a single unit.
    *  If a person writes a check for $100 to buy something, a transactional double-entry accounting system must record the following two entries to cover the single transaction: Debit $100 to Expense Account, Credit $100 to Checking Account
A transactional system would make both entries pass or both entries would fail.
11. What is a NoSQL database?
    * NoSQL database provides a mechanism for storage and retrieval of data that is modeled in means other than the tabular relations used in relational databases.
12. Explain the classical non-relational data models.
    * Document model - Set of documents, e.g. JSON strings
    * Key-value model - Set of key-value pairs
    * Hierarchical key-value - Hierarchy of key-value pairs
    * Wide-column model - Key-value model with schema
    * Object model - Set of OOP-style objects
13. Give few examples of NoSQL databases and their pros and cons.
    * MongoDB, CouchDB - JSON based document database
    * Redis - In-memory data structures server
    * Cassandra - Distributed wide column database














