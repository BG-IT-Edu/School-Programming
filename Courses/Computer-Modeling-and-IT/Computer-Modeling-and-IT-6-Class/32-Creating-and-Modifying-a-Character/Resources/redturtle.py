from turtle import *

# Създай обект на костенурката
my_turtle = Turtle()

# Задай форма на героя (триъгълник)
my_turtle.shape("turtle")

# Промени цвета на героя
my_turtle.color(____, ____)  # Липсващ код за цвят на очертанията и запълването

# Начало на запълването
my_turtle.begin_fill()

# Нарисувай правоъгълник
for _ in range(2):
    my_turtle.forward(200)
    my_turtle.left(90)
    my_turtle.forward(100)
    my_turtle.left(90)

# Край на запълването
my_turtle.end_fill()

done()
