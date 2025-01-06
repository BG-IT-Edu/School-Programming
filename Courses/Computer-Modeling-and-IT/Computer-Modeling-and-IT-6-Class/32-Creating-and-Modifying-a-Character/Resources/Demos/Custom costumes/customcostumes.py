from turtle import *

# Създаваме екран за рисуване
screen = Screen()
screen.title("Демо на собствен костюм с GIF изображение")

# Регистрираме GIF изображението като нов костюм
screen.register_shape("mario.gif")

# Създаваме нашия герой (костенурка) и задаваме костюма
turtle = Turtle()
turtle.shape("mario.gif")

# Преместваме героя за демонстрация
turtle.penup()
turtle.goto(-100, 0)  # Преместваме героя на централна позиция
turtle.stamp()        # Оставяме отпечатък с новия костюм

# Скриваме героя след като отпечатъкът е направен
turtle.hideturtle()

# Изчакваме потребителя да затвори прозореца
screen.mainloop()
