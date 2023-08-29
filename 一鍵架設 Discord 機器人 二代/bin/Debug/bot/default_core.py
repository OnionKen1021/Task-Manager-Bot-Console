import os
import json
import discord

intents = discord.Intents.all()

bot = discord.Bot(intents=intents)

with open('config.json') as f:
    data = json.load(f)

TOKEN = data["token"]

@bot.event
async def on_ready():
    print(f"{bot.user} 已經成功上線!")

bot.run(TOKEN)