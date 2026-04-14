Steps to make the app save data to your local MySQL/MariaDB (phpMyAdmin/XAMPP/WAMP)

1) Install NuGet package
- Open Visual Studio > Tools > NuGet Package Manager > Package Manager Console
- Run: Install-Package MySql.Data

2) Update connection string
- Open Form1.cs and change ConnectionString constant, example:
  Server=127.0.0.1;Port=3306;Database=test;Uid=root;Pwd=your_password;SslMode=none;

3) Create database and table
- Run the SQL in create_customers.sql using phpMyAdmin > SQL tab or MySQL client.

4) Uncomment direct MySql usage (optional)
- After installing MySql.Data you can edit Form1.cs and replace the reflection block with:
  using MySql.Data.MySqlClient;
  using (var conn = new MySqlConnection(ConnectionString)) { ... }

5) Test
- Run the WinForms app, fill fields, click Save. If success you'll see "Saved. Rows affected: 1".
- If failure, note exact exception text and check:
  - ConnectionString values
  - MySQL server running
  - Port 3306 accessible
  - Table exists

If you want, I can change code to use `MySqlConnector` package instead (it is recommended by some).