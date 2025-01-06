from turtle import *

# Създаваме екран за рисуване
screen = Screen()
screen.title("Демо на вградените костюми на героя")

# Създаваме нашия герой (костенурка)
turtle = Turtle()

# Списък с костюмите на героя
shapes = ['arrow', 'turtle', 'circle', 'square', 'triangle', 'classic']

# Начална позиция за изчертаване на костюмите
turtle.penup()
turtle.goto(-250, 0)
turtle.speed(1)

# Демонстрираме всяка от формите в списъка
for shape in shapes:
    turtle.shape(shape)      # Променяме формата (костюма) на героя
    turtle.stamp()           # Оставяме отпечатък на текущата форма
    turtle.forward(100)      # Преместваме героя настрани за следващата форма

# Скриваме героя след като всички отпечатъци са направени
turtle.hideturtle()

# Изчакваме потребителя да затвори прозореца
screen.mainloop()
