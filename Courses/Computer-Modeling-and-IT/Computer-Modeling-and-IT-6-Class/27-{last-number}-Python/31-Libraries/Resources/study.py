# Получаваме текущото време
current_time = time.localtime()

# Определяме часа
current_hour = current_time.tm_hour

# Функция, която проверява дали е време за учене или почивка
def check_schedule(hour):
    if 8 <= hour < 12:
        return "Време е за учене! Да работим усилено!"
    elif 12 <= hour < 14:
        return "Обедна почивка! Насладете се на храната си!"
    elif 14 <= hour < 17:
        return "Отново е време за учене! Давайте всичко от себе си!"
    elif 17 <= hour < 19:
        return "Може да се отпуснете малко, време е за почивка!"
    else:
        return "Вече е късно, време е да си починете и да се подготвите за следващия ден!"

# Показваме текущото време
print("Текущото време е:", time.strftime("%H:%M:%S", current_time))
# Показваме съобщението според времето
print(check_schedule(current_hour))
