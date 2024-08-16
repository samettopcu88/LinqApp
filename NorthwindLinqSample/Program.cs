// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using NorthwindLinqSample.Models;
using NorthwindLinqSample.NorthwindDTO;

NorthwindContext context = new NorthwindContext();
//Method Syntax
//var customers = context.Customers.ToList();

//Query Syntax
//var customers = from customer in context.Customers
//                select customer;

//foreach (var customer in customers)
//{
//    Console.WriteLine($"Customer ID : {customer.CustomerId} - Company Name : {customer.CompanyName}");
//}
//Country UK ve ya USA olan müşteriler
//Query Syntax
//var customers = from customer in context.Customers
//                where customer.Country == "UK" || customer.Country == "USA"
//                select customer;

//Method Syntax
//var customers = context.Customers.Where(x => x.Country == "UK" || x.Country == "USA");
//foreach (var customer in customers)
//{
//    Console.WriteLine($"Customer ID : {customer.CustomerId} - Company Name : {customer.CompanyName} - Country : {customer.Country}");
//}

//Country UK ve ya USA olup Country e göre artan Region a göre azalan sıralama
//Query Syntax
//var customers = from customer in context.Customers
//                where customer.Country == "UK" || customer.Country == "USA" || customer.Country=="France" || customer.Country =="Mexico"
//                orderby customer.Country ascending,
//                customer.Region descending
//                select customer;
//Method Syntax
//var customers = context.Customers
//    .Where(x => x.Country == "UK" || x.Country == "USA" || x.Country == "Mexico" || x.Country == "France")
//    .OrderBy(x => x.Country).ThenByDescending(x => x.Region);
//foreach (var customer in customers)
//{
//    Console.WriteLine($"Customer ID : {customer.CustomerId} - Company Name : {customer.CompanyName} - Country : {customer.Country} " +
//        $"Region : {customer.Region}");
//}

//Country UK,USA,Mexico,France olup Country e göre artan Region a göre azalan sıralama.Döüş tipinde sadece CustomerID, CompanyName,Country ve Region Olacak
//Query SYntax
//var customers = from customer in context.Customers
//                where customer.Country == "UK" || customer.Country == "USA" || customer.Country == "France" || customer.Country == "Mexico"
//                orderby customer.Country ascending,
//                customer.Region descending
//                select new CustomerDTO
//                {
//                    CustomerID = customer.CustomerId,
//                    CustomerName = customer.CompanyName,
//                    Country = customer.Country,
//                    Region = customer.Region
//                };
//Method Syntax
//var customers = context.Customers
//    .Where(x => x.Country == "UK" || x.Country == "USA" || x.Country == "Mexico" || x.Country == "France")
//    .OrderBy(x => x.Country).ThenByDescending(x => x.Region)
//    .Select(x => new CustomerDTO
//    {
//        CustomerID = x.CustomerId,
//        CustomerName = x.CompanyName,
//        Country = x.Country,
//        Region = x.Region
//    });
//foreach (var customer in customers)
//{
//    Console.WriteLine($"Customer ID : {customer.CustomerID} - Company Name : {customer.CustomerName} - Country : {customer.Country} " +
//        $"Region : {customer.Region}");
//}


//Country UK, USA, Mexico, France olup Country e göre artan Region a göre azalan sıralama.Döüş tipinde sadece CustomerID, CompanyName, Country ve Region Olacak
//Query SYntax
//var customers = from customer in context.Customers
//                where customer.Country == "UK" || customer.Country == "USA" || customer.Country == "France" || customer.Country == "Mexico"
//                orderby customer.Country ascending,
//                customer.Region descending
//                select new 
//                       {
//                           CustomerID = customer.CustomerId,
//                           CustomerName = customer.CompanyName,
//                           Country = customer.Country,
//                           Region = customer.Region
//                       };

//Method Syntax
//var customers = context.Customers
//    .Where(x => x.Country == "UK" || x.Country == "USA" || x.Country == "Mexico" || x.Country == "France")
//    .OrderBy(x => x.Country).ThenByDescending(x => x.Region)
//    .Select(x => new 
//                 {
//                     CustomerID = x.CustomerId,
//                     CustomerName = x.CompanyName,
//                     Country = x.Country,
//                     Region = x.Region
//                 });
//foreach (var customer in customers)
//{
//    Console.WriteLine($"Customer ID : {customer.CustomerID} - Company Name : {customer.CustomerName} - Country : {customer.Country} " +
//        $"Region : {customer.Region}");
//}

//Tekrar etmeyen - distinct contacttile bilgilerini alalım
//Query SYntax
//var contactTitles = (from customer in context.Customers
//                    select customer.ContactTitle).Distinct();
//Method Syntax
//var contactTitles = context.Customers
//    .Select(x => x.ContactTitle).Distinct();
//foreach (var contactTitle in contactTitles)
//    Console.WriteLine(contactTitle);

//Müşteri isminde A geçen müşterilerin şirket bilgisi ve sipaiş bilgilerini ekrana yazalım
//Query Syntax
//var customerOrders = from customer in context.Customers
//                     where customer.CompanyName.Contains("A")
//                     select new 
//                     {
//                         CustomerID = customer.CustomerId,
//                         CompanyName = customer.CompanyName,
//                         Orders = customer.Orders
//                     };
//Method Syntax
//var customerOrders = context.Customers
//    .Where(x => x.CompanyName.Contains("A"))
//    .Select(x => new
//    {
//        CustomerID = x.CustomerId,
//        CompanyName = x.CompanyName,
//        Orders = x.Orders
//    });
//Console.WriteLine($"Kayıt Sayısı : {customerOrders.Count()}");
//Console.WriteLine(new string('-', 100));
//foreach (var item in customerOrders)
//{
//    Console.WriteLine($"CustomerID : {item.CustomerID} - Company Name : {item.CompanyName}");
//    Console.WriteLine("Customer Orders");
//    foreach (var orderItem in item.Orders)
//    {
//        Console.WriteLine($"Order ID : {orderItem.OrderId} - OrderDate : {orderItem.OrderDate}");
//    }
//    Console.WriteLine(new string('*', 100));
//}

//var orderQuantity = (from order in context.OrderDetails
//                    where order.ProductId == 30
//                    select order).Count();
//Console.WriteLine(orderQuantity);

//var orderProductCountAvarage = (from order in context.OrderDetails
//                                where order.ProductId == 30
//                                select order).Average(x=>x.Quantity);

//Console.WriteLine(orderProductCountAvarage);

//var orderPriceAvarage = (from order in context.OrderDetails
//                         where order.Product.ProductName == "Konbu"
//                         select (order.UnitPrice * order.Quantity)).Average();
//Console.WriteLine(orderPriceAvarage);

//var productListByCatgory = from product in context.Products
//                            where product.Category.CategoryName == "Seafood"
//                            select product;
//foreach (var item in productListByCatgory)
//{
//    Console.WriteLine($"Product ID : {item.ProductId} - Product Name : {item.ProductName} - Stok : {item.UnitsInStock}");
//}


//var customers = from customer in context.Customers
//                where customer.Orders.Count >= 10
//                select new
//                {
//                    CustomerName = customer.CompanyName
//                };
//foreach (var item in customers)
//{
//    Console.WriteLine(item.CustomerName);
//}

//var customerTotal = (from orderTotal in context.OrderDetails
//                     where orderTotal.Order.Customer.CompanyName == "Eastern Connection"
//                     select orderTotal.Quantity * orderTotal.UnitPrice).Sum();
//Console.WriteLine(customerTotal);

//Query Syntax
//var productsByCategory = from product in context.Products
//                         join category in context.Categories
//                         on product.CategoryId equals category.CategoryId
//                         orderby category.CategoryId ascending, product.ProductId ascending
//                         select new
//                         {
//                             CategoryID = category.CategoryId,
//                             CategoryName = category.CategoryName,
//                             ProductID = product.ProductId,
//                             ProductName = product.ProductName,
//                         };
//Method Syntax
var productsByCategory = context.Products
    .Join(context.Categories,
    p => p.CategoryId,
    c => c.CategoryId,
    (product, category) => new
    {
        CategoryID = category.CategoryId,
        CategoryName = category.CategoryName,
        ProductID = product.ProductId,
        ProductName = product.ProductName,
    }).OrderBy(x=>x.CategoryID).ThenBy(x=>x.ProductID);
foreach (var item in productsByCategory)
{
    Console.WriteLine($"CategoryID : {item.CategoryID} - CategoryName : {item.CategoryName} - ProductID : {item.ProductID} - ProductName : {item.ProductName}");
}