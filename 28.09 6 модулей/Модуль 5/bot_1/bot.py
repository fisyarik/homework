import random
import requests
from datetime import datetime, timedelta
from telegram import Update, ReplyKeyboardMarkup
from telegram.ext import Application, CommandHandler, MessageHandler, filters, CallbackContext

# Конфигурация
BOT_TOKEN = "8698032041:AAFnXPzfagN8Rk73im_wlkZVUjowdGE9kX0"
WEATHER_API_KEY = "9875234495dd4dceb83214807262802"

# Наборы данных
weather_cities = ("Париж", "Рим", "Барселона", "Амстердам", "Прага",
                  "Вена", "Будапешт", "Лиссабон", "Афины", "Дубровник")
train_cities = frozenset(["Санкт-Петербург", "Гатчина", "Выборг", "Луга", "Тихвин",
                        "Кингисепп", "Сланцы", "Тосно", "Волосово", "Приозерск"])
flight_cities = {"Сочи": "Россия", "Анталья": "Турция", "Дубай": "ОАЭ",
                 "Паттайя": "Таиланд", "Гоа": "Индия", "Майами": "США",
                 "Ницца": "Франция", "Барселона": "Испания",
                 "Рио-де-Жанейро": "Бразилия", "Бали": "Индонезия"}

# Загрузка вредных советов
def load_bad_tips():
    with open('bad_tips.txt', 'r', encoding='utf-8') as f:
        return [line.strip() for line in f.readlines() if line.strip()]

bad_tips = load_bad_tips()

# Функции для получения данных из API
def get_weather_advice():
    city = random.choice(weather_cities)
    date = (datetime.now() + timedelta(days=7)).strftime('%Y-%m-%d')
    url = f"http://api.weatherapi.com/v1/forecast.json?key={WEATHER_API_KEY}&q={city}&dt={date}"
    try:
        response = requests.get(url)
        data = response.json()
        temp = data['forecast']['forecastday'][0]['day']['avgtemp_c']
        return f"Прогноз погоды в {city} на {date}: средняя температура {temp}°C."
    except Exception as e:
        return f"Не удалось получить прогноз для {city}. Ошибка: {e}"

def get_train_advice():
    cities = list(train_cities)
    from_city = random.choice(cities)
    to_city = random.choice([c for c in cities if c != from_city])
    # Здесь должен быть запрос к API расписания электричек
    return f"Расписание электричек: {from_city} → {to_city}. Проверьте актуальное расписание на сайте!"

def get_flight_advice():
    city, country = random.choice(list(flight_cities.items()))
    # Здесь должен быть запрос к OpenSky API
    return f"Информация о рейсах в {city} ({country}). Проверьте актуальные рейсы онлайн!"

# Выбор случайного API для платного совета
def get_paid_advice():
    api_functions = [get_weather_advice, get_train_advice, get_flight_advice]
    chosen_api = random.choice(api_functions)
    return chosen_api()

# Обработчики команд
async def start(update: Update, context: CallbackContext):
    keyboard = [["Бесплатный совет", "Платный совет"]]
    reply_markup = ReplyKeyboardMarkup(keyboard, resize_keyboard=True)
    await update.message.reply_text("Привет! Выберите тип совета:", reply_markup=reply_markup)

async def handle_message(update: Update, context: CallbackContext):
    text = update.message.text
    if text == "Бесплатный совет":
        tip = random.choice(bad_tips)
        await update.message.reply_text(f" вредненький советик: {tip}")
    elif text == "Платный совет":
        advice = get_paid_advice()
        await update.message.reply_text(f" $$$Платный совет$$$: {advice}")

# Основной блок
def main():
    application = Application.builder().token(BOT_TOKEN).build()
    application.add_handler(CommandHandler("start", start))
    application.add_handler(MessageHandler(filters.TEXT & ~filters.COMMAND, handle_message))
    application.run_polling()

if __name__ == "__main__":
    main()
