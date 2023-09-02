create Table Clients(
	id integer primary key,
    document varchar (15),
    doctype varchar(2),
    names varchar(50),
    lastnames varchar(50),
    birth datetime,
    phone varchar(15),
    email varchar (50),
    country integer,
    address varchar(50),
    neighbornhood varchar(50),
    civilStatus integer,
    numChild integer,
    job varchar(50),
    acceptTerm bool,
    acceptData bool,
    acceptNotifications bool
);

