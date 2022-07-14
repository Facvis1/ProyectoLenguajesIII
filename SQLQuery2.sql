set IDENTITY_INSERT Orders ON
insert into Orders (OrderId, OrderDate, Username, FirstName, LastName, Address, City, State, PostalCode, Country, Phone, Email, Total, PaymentTransactionId, HasBeenShipped, TotalOrden, Preferences, Estado, FechaEnv, Cadete, TipoPago)
values (0, 131, 'username','userfirstname', 'userlastname', 'adasd', 'Ciudad de Salta', 'Salta','4401', 'Argentina', '3886123456', 'esmiemail@gmail.com', 1323, 100, '', '$154', '','Pendiente', 120, '', '');
set IDENTITY_INSERT Orders OFF