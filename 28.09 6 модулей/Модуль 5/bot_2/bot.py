import random
from telegram import ReplyKeyboardMarkup
from telegram.ext import Application, CommandHandler, MessageHandler, filters

# Токен бота (замените на свой)
BOT_TOKEN = "8666843464:AAErNfcUiaHMFTtjnkBkwsy4p-ppP4jlEjQ"

# Словарь для хранения советов
advice_dict = {
    "free": [],
    "paid": []
}

# Кортеж с кнопками
buttons_tuple = ("Бесплатный совет", "Платный совет")

# Загрузка советов из файлов
def load_advice_from_files():
    with open("вредные_советы.txt", "r", encoding="utf-8") as f:
        advice_dict["free"] = [line.strip() for line in f.readlines() if line.strip()]
    with open("полезные_советы.txt", "r", encoding="utf-8") as f:
        advice_dict["paid"] = [line.strip() for line in f.readlines() if line.strip()]

# Клавиатура
keyboard = ReplyKeyboardMarkup(
    keyboard=[list(buttons_tuple)],
    resize_keyboard=True
)

# Обработчик команды /start
async def start(update, context):
    await update.message.reply_text(
        "Выберите тип совета:",
        reply_markup=keyboard
    )

# Обработчик сообщений (нажатия на кнопки)
async def handle_message(update, context):
    text = update.message.text
    if text == "Бесплатный совет":
        advice = random.choice(advice_dict["free"])
        await update.message.reply_text(f" Вредный совет: {advice}")
    elif text == "Платный совет":
        advice = random.choice(advice_dict["paid"])
        await update.message.reply_text(f" Платный совет: {advice}")

# Запуск бота
def main():
    load_advice_from_files()  # Загружаем советы при запуске
    application = Application.builder().token(BOT_TOKEN).build()
    application.add_handler(CommandHandler("start", start))
    application.add_handler(MessageHandler(filters.TEXT & ~filters.COMMAND, handle_message))
    application.run_polling()

if __name__ == "__main__":
    main()
