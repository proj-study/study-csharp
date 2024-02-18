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

### 4. LINQを使用したデータ処理
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

---
### 5. 配列とジェネリックコレクション
   目標：配列とジェネリックコレクションの使用方法を理解し、それぞれの特徴を比較する。

課題：

1. 配列：  [答えの例](5-1.cs)
- 整数型の配列を作成し、5つの要素を入力できるようにする。
- 入力された要素をすべて表示する。
- 配列の最大値と最小値を求め、出力する。  

2. ジェネリックコレクション： [答えの例](5-2.cs)
- List<int>型のジェネリックコレクションを作成し、5つの要素を入力できるようにする。
- 入力された要素をすべて表示する。
- コレクションに要素を追加、削除、検索する機能を実装する。

3. 比較： [答えの例](5-3.md)
- 配列とジェネリックコレクションそれぞれの実装における利点と欠点を比較する。
- それぞれのデータ構造が適している状況について考察する。

- ヒント：
  - 配列： 
    - Array.CreateInstance() メソッドを使用して、新しい配列を作成できます。
    - for ループを使用して、配列の要素を処理できます。
    - Array.Max() と Array.Min() メソッドを使用して、配列の最大値と最小値を求めることができます。
  - ジェネリックコレクション：
    - List<T> クラスを使用して、新しいジェネリックコレクションを作成できます。
    - Add(), Remove(), Contains() メソッドを使用して、コレクションに要素を追加、削除、検索できます。


---
### 6. ファイル操作
目標：ファイルの読み書き処理を行い、テキストファイルの内容を編集する。
- 課題：
  - テキストファイルを読み込み、その内容を表示するプログラムを作成する。
  - ユーザー入力を受け取り、その内容をテキストファイルに追加するプログラムを作成する。
  - テキストファイルの内容を編集し、特定の文字列を別の文字列に置換するプログラムを作成する。
- ヒント：
  - File.ReadAllText() メソッドを使用して、テキストファイルを読み込むことができます。
  - File.WriteAllText() メソッドを使用して、テキストファイルに書き込むことができます。
  - StreamWriter クラスを使用して、テキストファイルに逐次書き込みを行うことができます。
  - String.Replace() メソッドを使用して、文字列を置換することができます。  

  [答えの例](6.md)

---
### 7. 文字列処理
目標：文字列操作の各種機能を使いこなし、複雑な文字列処理を行う。
- 課題：
  - ユーザー入力を受け取り、その文字列の長さを表示するプログラムを作成する。
  - 文字列から特定の部分文字列を抽出するプログラムを作成する。
  - 文字列を大文字または小文字に変換するプログラムを作成する。
  - 複数の文字列を結合するプログラムを作成する。
- ヒント：
  - string.Length プロパティを使用して、文字列の長さを取得できます。
  - string.IndexOf() メソッドを使用して、部分文字列の位置を取得できます。
  - string.Substring() メソッドを使用して、部分文字列を抽出できます。
  - string.ToUpper() と string.ToLower() メソッドを使用して、文字列を大文字または小文字に変換できます。
  - string.Concat() メソッドを使用して、複数の文字列を結合できます。
    
  [答えの例](7.md)

---
### 8. 関数とラムダ式
目標：関数を活用してコードを簡潔に記述し、ラムダ式を用いて匿名関数を定義する。

- 課題：
  - 2つの整数を引数として受け取り、その和を返す関数を作成する。
  - 文字列を引数として受け取り、その文字列の長さを返す関数を作成する。
  - リストを受け取り、そのリストに含まれる偶数の数を返す関数を作成する。
  - リストの要素をすべて大文字に変換するラムダ式を作成する。
  - リストの偶数の要素のみを抽出するラムダ式を作成する。
  -  2つのリストを結合し、重複する要素を削除するラムダ式を作成する。  

  [答えの例](8.md)

---
