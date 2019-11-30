using System;
using System.Collections.Generic;
using System.Linq;

namespace Concept.Linq.Lesson0 {
    class Human {
        public string Name { get; }
        public int Age { get; }
        public Human(string name, int age) => (Name, Age) = (name, age);
    }
    class Main {
        public void Run() {
            List<Human> humans = CreateHumans();
            Shows(Query0(in humans));
        }
        private List<Human> CreateHumans() {
            return new List<Human> {
                new Human("A", 0),
                new Human("B", 1),
                new Human("C", 2),
                new Human("D", 3),
                new Human("E", 4),
                new Human("F", 5),
            };
        }
        private IEnumerable<Human> Query0(in List<Human> humans) {
            return from h in humans
                   where 1 == (h.Age % 2)
                   select h;
        }
        private void Shows(in IEnumerable<Human> humans) {
            foreach (var h in humans) {
                Console.WriteLine($"name={h.Name}, age={h.Age}");
            }
        }
    }
}
