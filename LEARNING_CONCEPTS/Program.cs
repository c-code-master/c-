using System;
using System.Diagnostics;
using System.Threading;

namespace LEARNING_CSHARP
{
    /// <summary>
    /// Startup Class
    /// </summary>
    class Program
    {
        /// <summary>
        /// Startup Function
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Inline Comment

            /*

				Block Comment

			 */

            // برای دوره پیشرفته
            // قرار می‌گیرند stack تعریف می‌شوند، در داخل function تمامی متغیرهایی که در داخل
            // می‌شوند، مطلقا مقدار اولیه ندارند allocate قرار گرفته و یا اصطلاحا stack تمامی متغیرهایی که در داخل
            // reference type و متغیرهای value type یا primitive type متغیرها به طور کلی به دو دسته تقسیم می‌شوند. متغیرهای
            // متغیرهایی هستند که خودشان و مقدارشان در یک جا قرار دارد value type یا primitive type متغیرهای
            //قرار داشته و اصطلاحا به آن اشاره می‌کنند heap قرار دارند ولی مقدارشان در داخل) heap و یا sttack متغیرهایی هستند که خودشان در یک جا (یا در reference type متغیرهای

            // برای دوره مقدماتی
            // در زبان سی‌شارپ، هرگاه متغیری را در داخل یک فانکشن تعریف نماییم، اصطلاحا به آن متغیر محلی اطلاق می‌شود
            // در زبان سی‌شارپ، هرگاه یک متغیر محلی تعریف نماییم، مطلقا مقدار اولیه ندارد

            // **********
            // variable declaration
            //int x;
            //int y;
            // **********

            // **********
            //int x, y;
            // **********

            // **********
            //int x, y;

            //y = x + 10;
            // **********

            // **********
            //int x;
            //x = 10; // initial value
            // **********

            // **********
            //int x = 10;
            // **********

            // **********
            //int x = 10;
            //int y = x + 5;
            // **********

            // x + y =>
            // + operator عملگر
            //	x, y operand عملوند

            // **********
            //int x = 10;

            //x = x + 5;

            //x += 5;
            // **********

            // **********
            //int x = 10;

            //x = x + 1;
            //x += 1;
            //x++;
            //++x;
            // **********

            // **********
            //int x = 10;

            //x = x - 1;
            //x -= 1;
            //x--;
            //--x;
            // **********
            string strs = "32";
            int b=System.Convert.ToInt32(strs);
            System.Console.WriteLine(b);
            Thread.Sleep(0);
            

            // **********
            //int x = 10;

            //int y = x++; // y = 10, x = 11
            //int z = ++x; // z = 11, x = 11
            // **********

            // **********
            // primitive (value) types

            // byte => byt
            // int => int
            // long => lng

            // short => sht
            // uint
            // ulong

            // single => sng
            // double => dbl
            // decimal => dec

            // char => chr
            // bool => bln
            // **********

            // تمامی متغیرهایی که تعریف می‌کنیم باید با معنی باشند و نباید از محفف در نام آنها استفاده کنیم
            //long x;
            //long firstnumber; // pascal case
            //long lngfirstnumber; // type prefix

            // **********
            // هر متغیری از هر جنسی را می‌توان در داخل متغیری از همان جنس قرار داد
            // اعم از این که جنس آنرا بشناسیم یا نشناسیم

            //int x = 10;
            //int y = 20;

            //x = y;
            //y = x;

            //baghali x;
            //baghali y;

            //x = y;
            //y = x;

            // ولی هرگاه بخواهیم متغیری از یک جنس را در داخل متغیری از جنس دیگری
            // قرار دهیم، سه حالت امکانپذیر است

            // 1. می توان با خیال راحت
            // 2. می توان به شرط آنکه مسوولیت آن را بپذیریم
            // 3. مطلقا نمی‌شود

            // 1
            //int x = 10;
            //long y = 20;

            // implicit = ضمنی = تلویحی
            //y = x; // implicit casting!

            // 2

            // x = y; // compiler error!
            //x = (int)y; // explicit casting!

            // 3

            //int x = 123;
            //string s = "123";

            // s = x; // complile error!
            // x = s; // complile error!
            //s = x.tostring();
            //int x = system.convert.toint32(s);
            // **********

            // **********
            // == (not =)		!= (not <>)		<		>		<= (not =<)		>= (not =>)
            // **********

            // **********
            //int x = 1;

            //if (x == 1)
            //{
            //	system.console.writeline("dad!");
            //}

            //if (x == 1)
            //{
            //	system.console.writeline("dad!");
            //}
            //else
            //{
            //	system.console.writeline("bidad!");
            //}

            // infinitive loop
            //while (x == 1)
            //{
            //	system.console.writeline("dad!");
            //}
            // **********

            // **********
            // در زبان سی‌شارپ، در صورتی که در داخل یک بلاک بیش از یک دستور بنویسیم، موظف هستیم که حتما
            // آکولاد باز و بسته را بنویسیم. ولی در صورتی که بخواهیم در داخل یک بلاک، صرفا یک دستور بنویسیم
            // می‌توانیم آکولاد باز و بسته را ننویسیم. ولی دقت داشته باشید که در رسم‌الخط حرفه‌ای، حتی اگر
            // یک دستور هم می‌نویسیم، باید آکولاد باز و بسته را بنویسیم

            // not ok!
            //if (x == 1)
            //	system.console.writeline("dad!");

            //if (x == 1)
            //{
            //	system.console.writeline("dad!");
            //}
            // **********

            // **********
            //int intindex = 1;

            //while (intindex <= 10)
            //{
            //	// do something(s)

            //	intindex++;
            //}
            // **********

            // **********
            //int intindex = 1;

            //while (intindex <= 10)
            //{
            //	console.writeline("hello, world!");

            //	intindex++;
            //}
            // **********

            // **********
            //system.console.write("how many numbers do you have: ");

            ////string strnumbercount = system.console.readline();

            //string strnumbercount =
            //	system.console.readline();

            //int intnumbercount =
            //	system.convert.toint32(strnumbercount);

            //int intsum = 0;

            //int intindex = 1;

            //while (intindex <= intnumbercount)
            //{
            //	string strmessage = "[" + intindex + "] -> ";

            //	system.console.write(strmessage);

            //	string strnumber =
            //		system.console.readline();

            //	int intnumber =
            //		system.convert.toint32(strnumber);

            //	//int intnumber =
            //	//	system.convert.toint32(system.console.readline());

            //	intsum += intnumber;

            //	intindex++;
            //}

            //system.console.writeline("the sum of these numbers is " + intsum);
            // **********

            // **********
            //string strinput =
            //	system.console.readline();

            //if (strinput == "1")
            //{
            //	system.console.writeline("10");
            //}
            //else
            //{
            //	if (strinput == "2")
            //	{
            //		system.console.writeline("20");
            //	}
            //	else
            //	{
            //		if (strinput == "3")
            //		{
            //			system.console.writeline("30");
            //		}
            //		else
            //		{
            //			if (strinput == "4")
            //			{
            //				system.console.writeline("40");
            //			}
            //			else
            //			{
            //				if (strinput == "5")
            //				{
            //					system.console.writeline("50");
            //				}
            //				else
            //				{
            //					system.console.writeline("not a valid input!");
            //				}
            //			}
            //		}
            //	}
            //}
            // **********

            // **********
            //string strinput =
            //	system.console.readline();

            //switch (strinput)
            //{
            //	case "1":
            //	{
            //		system.console.writeline("10");
            //		break;
            //	}

            //	case "2":
            //	{
            //		system.console.writeline("20");
            //		break;
            //	}

            //	case "3":
            //	{
            //		system.console.writeline("30");
            //		break;
            //	}

            //	case "4":
            //	{
            //		system.console.writeline("40");
            //		break;
            //	}

            //	case "5":
            //	case "6":
            //	case "7":
            //	case "8":
            //	case "9":
            //	{
            //		system.console.writeline("50");
            //		break;
            //	}

            //	default:
            //	{
            //		system.console.writeline("not a valid input!");
            //		break;
            //	}
            //}
            // **********

            // **********
            //string strinput =
            //	system.console.readline();

            //switch (strinput)
            //{
            //	// خاکبرداری
            //	case "1":
            //	{
            //		system.console.writeline("step (1)");

            //		goto case "2";
            //	}

            //	// اسکلت
            //	case "2":
            //	{
            //		system.console.writeline("step (2)");

            //		goto case "3";
            //	}

            //	// سفت‌کاری
            //	case "3":
            //	{
            //		system.console.writeline("step (3)");

            //		goto case "4";
            //	}

            //	// نازک‌کاری
            //	case "4":
            //	{
            //		system.console.writeline("step (4)");
            //		break;
            //	}
            //}
            // **********

            // **********
            //int intnumber = 10;

            //while (intnumber < 5)
            //{
            //	system.console.writeline("hello, world!");
            //}

            //do
            //{
            //	system.console.writeline("hello, world!");
            //} while (intnumber < 5); // ; -> is requred!
            // **********

            // **********
            //for (a; b; c)
            //{
            //	d;
            //}

            // a, b, d, c, b, d, c, b, d, c,...
            // **********

            // **********
            //int intindex = 1;

            //while (intindex <= 10)
            //{
            //	// do something(s)!

            //	intindex++;
            //}

            //for (int intindex = 1; intindex <= 10; intindex++)
            //{
            //	system.console.writeline("hello, world!");
            //}
            // **********

            // **********
            // snippet
            // **********

            // **********
            // هرگاه کامپایلر به دستور
            // break
            // برخورد نماید
            // از آخرین حلقه‌ای که در داخل آن قرار دارد خارج می‌شود

            ////...
            //// a
            //while (1 == 1)
            //{
            //	//...
            //	// b
            //	while (1 == 1)
            //	{
            //		//...
            //		// c
            //		if (1 == 1)
            //		{
            //			//...
            //			break;
            //		}
            //		// d
            //		//...
            //	}
            //	// e
            //	//...
            //}
            //// f
            ////...

            // هرگاه کامپایلر به دستور
            // continue
            // برخورد نماید
            // به ابتدای آخرین حلقه‌ای که در داخل آن قرار دارد وارد شده و شرط را تست می‌کند

            //int intindex = 1;

            //while (intindex <= 10)
            //{
            //	if (intindex == 3)
            //	{
            //		intindex = 6;
            //		continue;
            //	}

            //	if (intindex == 8)
            //	{
            //		break;
            //	}

            //	system.console.writeline(">" + intindex);

            //	intindex++;
            //}
            // **********

            // **********
            //int a = 10;
            //int b = 20;
            //int c = 30;

            ////string strresult = "a = " + a + ", b = " + b + ", c = " + c;

            ////string strresult = string.format("a = {0}, b = {1}, c = {2}", a, b, c);

            //string strresult = string.format("a = {1}, b = {0}, c = {1}", a, b, c);

            //system.console.writeline(strresult);
            // **********

            // **********
            //string strfirstname = "dariush";
            //string strlastname = "tasdighi";

            //string strfullname =
            //	string.format("{0} {1}", strfirstname, strlastname);

            //system.console.writeline(strfullname);
            // **********

            // **********
            //string str = "a";
            //char chr = 'a'; // 65
            // **********

            // **********
            //bool blnresult = true;

            // عرف و حرفه‌ای نیست
            //if (blnresult == true)
            //{
            //}

            //if (blnresult)
            //{
            //}

            // عرف و حرفه‌ای نیست
            //if (!blnresult)
            //{
            //}

            //if (blnresult == false)
            //{
            //}
            // **********

            System.Console.Write("Press [ENTER] To Exit...");
            System.Console.ReadLine();
        }
    }
}
