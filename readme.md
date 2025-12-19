# 🎓 IELTS Calculator

> **IELTS Overall Score hisoblash uchun sodda va professional C# kutubxona**

[![.NET](https://img.shields.io/badge/.NET-512BD4?style=flat&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/C%23-239120?style=flat&logo=c-sharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![License](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)

---

## 📋 Mundarija

- [Loyiha haqida](#-loyiha-haqida)
- [Xususiyatlar](#-xususiyatlar)
- [Arxitektura](#-arxitektura)
- [O'rnatish](#-ornatish)
- [Ishlatish](#-ishlatish)
- [Hisoblash qoidasi](#-hisoblash-qoidasi)
- [Kategoriyalar](#-kategoriyalar)
- [Misol](#-misol)

---

## 🎯 Loyiha haqida

**IELTS Calculator** - bu IELTS imtihonining umumiy (Overall) balini to'g'ri hisoblash uchun mo'ljallangan Class Library va Console Application.

Loyiha **clean code** tamoyillariga amal qiladi va **beginner-friendly** tarzda yozilgan.

---

## ✨ Xususiyatlar

✅ **To'liq IELTS rounding qoidasini** qo'llaydi  
✅ **4 ta modulni** (Listening, Reading, Writing, Speaking) hisobga oladi  
✅ **Kategoriya aniqlash** (Expert, Very Good, Good, va boshqalar)  
✅ **Class Library** sifatida qayta ishlatish mumkin  
✅ **Console App** bilan oddiy interfeys  
✅ **Sodda va tushunarli** kod tuzilishi

---

## 🏗️ Arxitektura

Loyiha **2 ta asosiy qismdan** iborat:

```
📁 Solution
├── 📂 IeltsCalculatorService (Class Library)
│   └── 📂 Services
│       └── IeltsCalculator.cs
│
└── 📂 IeltsCalculatorApp (Console App)
    └── Program.cs
```

### Texnologiyalar

- **Framework:** .NET 6/7/8
- **Til:** C# 10+
- **Arxitektura:** Layered Architecture

---

## 🚀 O'rnatish

### 1️⃣ Class Library yaratish

```bash
# Visual Studio'da
Create new project → Class Library (.NET)
Project name: IeltsCalculatorService
```

### 2️⃣ Console App yaratish

```bash
Create new project → Console App
Project name: IeltsCalculatorApp
```

### 3️⃣ Reference ulash

```
IeltsCalculatorApp (Right click)
→ Add → Project Reference
→ IeltsCalculatorService (belgilash)
→ OK
```

---

## 💻 Ishlatish

### Class Library (IeltsCalculator.cs)

```csharp
using IeltsCalculatorService.Services;

var calculator = new IeltsCalculator();

double overall = calculator.CalculateOverall(6.5, 6.0, 6.5, 6.0);
string category = calculator.GetCategory(overall);

Console.WriteLine($"Overall Score: {overall}");  // 6.5
Console.WriteLine($"Category: {category}");      // Competent
```

### Console App (Program.cs)

```csharp
using System;
using IeltsCalculatorService.Services;

class Program
{
    static void Main()
    {
        var calculator = new IeltsCalculator();

        double listening = GetScore("Listening");
        double reading = GetScore("Reading");
        double writing = GetScore("Writing");
        double speaking = GetScore("Speaking");

        double overall = calculator.CalculateOverall(
            listening, reading, writing, speaking
        );

        string category = calculator.GetCategory(overall);

        Console.WriteLine($"\n📊 Overall IELTS Score: {overall}");
        Console.WriteLine($"🏆 Category: {category}");
    }

    static double GetScore(string skill)
    {
        Console.Write($"{skill} score: ");
        return double.Parse(Console.ReadLine());
    }
}
```

---

## 📐 Hisoblash qoidasi

IELTS Overall Score rasmiy qoidaga binoan hisoblanadi:

```
1. Average = (Listening + Reading + Writing + Speaking) / 4
2. Rounding:
   • 0.25 dan kichik → pastga (floor)
   • 0.25 - 0.75    → 0.5 ga yaxlitlash
   • 0.75 dan katta → yuqoriga (ceiling)
```

### Misol

| Listening | Reading | Writing | Speaking | Average | Overall |
|-----------|---------|---------|----------|---------|---------|
| 6.5       | 6.0     | 6.5     | 6.0      | 6.25    | **6.5** |
| 7.0       | 6.5     | 6.0     | 7.5      | 6.75    | **7.0** |
| 8.0       | 7.5     | 7.0     | 8.0      | 7.625   | **7.5** |

---

## 🏅 Kategoriyalar

| Ball    | Kategoriya  | Tavsif                        |
|---------|-------------|-------------------------------|
| 9.0     | Expert      | To'liq bilim                  |
| 8.0-8.5 | Very Good   | Juda yaxshi                   |
| 7.0-7.5 | Good        | Yaxshi                        |
| 6.0-6.5 | Competent   | Kompetent                     |
| 5.0-5.5 | Modest      | O'rtacha                      |
| 0-4.5   | Limited     | Cheklangan                    |

---

## 🎬 Misol

### Kirish

```
Listening score: 7.0
Reading score: 6.5
Writing score: 6.0
Speaking score: 7.5
```

### Natija

```
📊 Overall IELTS Score: 7.0
🏆 Category: Good
```

---

## 🤝 Hissa qo'shish

Pull request'lar qabul qilinadi! Katta o'zgarishlar uchun avval issue oching.

---

## 👨‍💻 Muallif

**Jamshidbek**

- GitHub: [@Jamxon](https://github.com/Jamxon)
- Email: aliyevjamkhan499@gmail.com

---

## ⭐ Qo'llab-quvvatlash

Agar loyiha foydali bo'lsa, ⭐ **star** bosing!

---

<div align="center">

**Omad tilayman IELTS imtihonida! 🎓**

Made with ❤️ using C# and .NET

</div>