from turtle import *

# Създаваме екран за рисуване
screen = Screen()
screen.title("Демо на различни цветове за героя")
screen.colormode(255)  # !!! ВАЖНО: Активираме RGB цветови модел

# Създаваме нашия герой (костенурка)
turtle = Turtle()
turtle.shape("turtle")
turtle.penup()
turtle.goto(-100, 0)
turtle.speed(1)

# Пример 1: Задаване на един цвят за целия герой
turtle.color("blue")  # Задаваме син цвят за героя
turtle.stamp()  # Оставяме отпечатък

# Пример 2: Задаване на два цвята - за очертанията и за запълването
turtle.color("red", "yellow")  # Червени очертания, жълто запълване
turtle.goto(0, 0)
turtle.stamp()

# Пример 3: Задаване на цвят чрез RGB модела
turtle.color(230, 100, 200)  # Използваме RGB стойности
turtle.goto(100, 0)
turtle.stamp()

# Скриваме героя след като отпечатъците са направени
turtle.hideturtle()

# Изчакваме потребителя да затвори прозореца
screen.mainloop()
