using System;
using System.Collections.Generic;

namespace С_ {
  // ПЕРЕЧИСЛЕНИЕ
  enum Models {AUDI, VOLVO, NISSAN, VOLKS, PORSHE, FORD};

  class Cars {
    int name_1 = 1;
    public int wheels = 2; // Доступно в других классах
    private float speed = 3f; // Доступно только в этом классе
    protected bool isWorking = true; // Доступно только в этом классе и в классах наследниках

    public static int test = 0; // static привязывает к Обьекту | Можно вызвать как Cars.test = 1

    public Models models; // Теперь доступна сущность Models

    public static void TestFunction () { // Cars.TestFunction()
      Console.WriteLine("Static function");
    }

    public void setValue (float speed, bool isWorking) {
      this.speed = speed; // Переопределит private speed
      this.isWorking = isWorking;
    }
    public virtual void getValues () { // virtual - означает что мы можем этот метод переопределить при наследовании
      Console.WriteLine("Cars speed " + this.speed + ", car is working " + this.isWorking);
    }
    public Cars (int wheels, float speed, bool isWorking) {
      this.speed = speed; // Переопределит private speed
      this.isWorking = isWorking;
      this.wheels = wheels;
    }
    public Cars () {}
  }

  class Trucks : Cars {
    public int passengers;
    public Trucks (int wheels, float speed, bool isWorking, int passengers) : base (wheels, speed, isWorking) {
      this.passengers = passengers;
    }
    public override void getValues() { // override - перезаписываем
      base.getValues(); // значение из базавого класса
      Console.WriteLine("Passengers "+ this.passengers);
    }
  }

  class MainClass {
    public static void Main(string[] args) {

      Cars audi = new Cars();
      audi.wheels = 3;
      audi.setValue(10f, false);
      audi.getValues(); // Cars speed 10, car is working False
      audi.models = Models.AUDI;
      Console.WriteLine(audi.wheels); // 3
      Console.WriteLine(audi.models); // AUDI
      //====================================================

      Cars volvo = new Cars();
      volvo.wheels = 6;
      volvo.setValue(159.16f, false);
      volvo.getValues(); // Cars speed 159.16, car is working False
      volvo.models = Models.VOLVO;
      Console.WriteLine(volvo.wheels); // 6
      Console.WriteLine(volvo.models); // VOLVO
      //=====================================================

      Cars kia = new Cars(5, 15.16f, true);
      Console.WriteLine(kia.wheels); // 5;
      //======================================================

      Console.WriteLine(Cars.test); // 0
      Cars.TestFunction(); // Static Function
      //======================================================

      Trucks man = new Trucks(8, 130.5f, false, 3);
      man.getValues(); 
      // Cars speed 130.5, car is working False
      // Passengers 3
      Console.WriteLine(man.passengers); // 3
    }
  }

  
}
