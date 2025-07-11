# 📚 Library Management System - ASP.NET MVC (Database-First)

این پروژه یک سیستم ساده‌ی مدیریت کتابخانه است که با استفاده از **ASP.NET MVC 5** و معماری **Database-First** پیاده‌سازی شده است.

---

## ✅ امکانات فعلی (تا این مرحله)

- طراحی دیتابیس با SQL Server و ساخت جدول‌های اصلی:
  - Books (کتاب‌ها)
  - Authors (نویسندگان)
  - Members (اعضا)
  - Publishers (ناشران)
  - BorrowRecords (سوابق امانت)
- ایجاد دیتابیس `LibraryDB` و پر کردن آن با داده‌های تستی
- اتصال پروژه‌ی ASP.NET MVC به دیتابیس با استفاده از **ADO.NET Entity Data Model (EDMX)**
- ساخت کنترلر و ویوهای CRUD کامل برای جدول `Books`
- نمایش، ویرایش، ثبت و حذف کتاب‌ها در رابط کاربری
- رفع خطاهای اتصال، تست ارتباط و اطمینان از کارکرد کامل مدل‌ها

---

## 🛠 تکنولوژی‌های استفاده شده

- ASP.NET MVC 5  
- Entity Framework 6 (Database First with EDMX)  
- SQL Server 2019  
- HTML/CSS + Razor Views  
- Bootstrap (پیش‌فرض قالب)

---

## 🚀 مراحل بعدی

- ساخت API با Web API 2 برای ارائه سرویس‌های RESTful
- افزودن CRUD برای جدول‌های دیگر (Members, Authors, BorrowRecords)
- افزودن جستجو، فیلتر و گزارش‌گیری
- طراحی UI حرفه‌ای‌تر با Bootstrap یا Tailwind

---

## ⚙️ اجرای پروژه

۱. دیتابیس `LibraryDB` را با اسکریپت `CreateDatabase.sql` بسازید  
۲. پروژه را در Visual Studio اجرا کنید  
۳. آدرس `/Books` را در مرورگر باز کنید تا لیست کتاب‌ها را ببینید

---

## ✍️ توسعه‌دهنده

> این پروژه برای تمرین و آموزش ASP.NET MVC با رویکرد دیتابیس‌محور ایجاد شده است.
