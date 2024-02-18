# 1. 最初に

---

#### 1. 「Hello, World!」クラスの拡張
基本的なコンソール出力を理解し、ユーザー入力を受け取る。
```C#
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
```
課題:  
上記のプログラムを拡張して、ユーザーに名前を入力させ、"Hello, [名前]!"と出力する機能を追加してください。

---

#### 2. 簡単な計算機の作成
目標: 基本的な算術演算とユーザー入力の取り扱いを学ぶ。

```C#
using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number 2:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int sum = number1 + number2;
            Console.WriteLine("Sum: " + sum);
        }
    }
}
```
課題:  
- 上記の計算機プログラムに、掛け算と割り算の機能を追加してください。  
- ユーザーが実行する演算の種類を選択できるようにしてください。

---

#### 3. 基本的なクラスとオブジェクト
目標: クラスの定義とオブジェクトの作成・使用方法を学ぶ。

```C#
using System;

namespace BasicClass
{
    class Animal
    {
        public string name;

        public void Speak()
        {
            Console.WriteLine(name + " says: Hello!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            myAnimal.name = "Dog";
            myAnimal.Speak();
        }
    }
}
```
課題:  
Animalクラスに新しいプロパティ（例: age）を追加し、Speakメソッドでその動物の年齢も出力するようにしてください。
