# 2. 基礎

### 1. ユーザー定義の例外クラスの作成
目標: 例外処理の理解を深め、独自の例外クラスを作成する。

```C#
using System;

namespace CustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a positive number:");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number < 0)
                {
                    throw new Exception("Number is not positive.");
                }
                Console.WriteLine("You entered a positive number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
```
課題:  
Exceptionクラスを継承して、 NegativeNumberExceptionとBigNumberExceptionいう独自の例外クラスを作成してください。  
この例外を使用して、ユーザーが負の数を入力した場合にNegativeNumberException、10よりも大きい数を入力した場合にBigNumberExceptionを投げられるようにサンプルコードを修正してください。  
また、それぞれの例外をキャッチして、エラーメッセージを出力してください。

[答えの例](1.cs)


---

### 2. コメントの追加
目標: コメントの重要性を理解し、XMLドキュメントコメントを使用してクラス、メソッド、変数の説明を書く。

```C#
using System;

namespace DocumentationExample
{
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine(calc.Add(5, 3));
            Console.WriteLine(calc.Subtract(5, 3));
        }
    }
}
```

課題:  
以下のコードにXMLドキュメントコメントを追加し、各クラス、メソッド、および主要な変数の目的、引数、返り値を説明してください。

[答えの例](2.cs)


### 3: コーディングスタイルの修正
目標: コーディングスタイルと命名規則の重要性を理解し、可読性を向上させる。

```C#
using System;
using System.Collections.Generic;

namespace sampleApplication
{
    class myClass
    {
        public static void my_DisplayItemsAndCalculateResult(int Param1, List<string> Param2)
        {
            for (int i = 0; i < Param2.Count; i++)
            {
                Console.WriteLine(Param2[i] + " " + Param1);
            }

            int result = 0;
                result = Param1 * 5;
            Console.WriteLine("result is " + result);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string>{"one", "two", "three"};
            myClass.my_DisplayItemsAndCalculateResult(5, myList);
        }
    }
}
```

課題:  
上記のコードにはいくつかのコーディングスタイルの問題があります。命名規則、クラス名、変数名のケースを修正し、コードの可読性を向上させてください。

[答えの例](3.md)
---

### 3. LINQを使用したデータ処理
目標: LINQを使用してコレクションデータを処理する方法を学ぶ。

サンプルコード:

```C#
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
            Console.WriteLine("Even numbers:");
            foreach (var n in evenNumbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
```
課題:  
上記のコードに新しい機能を追加して、偶数だけでなく、3で割り切れる数も出力するようにしてください。  
また、出力を「偶数」と「3で割り切れる数」と明確に区分してください。

[答えの例](4.cs)