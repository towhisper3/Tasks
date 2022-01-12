import re
import csv
import requests

url = "https://movie.douban.com/top250"
headers = {"User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/94.0.4606.81 Safari/537.36"}

resp = requests.get(url=url, headers=headers)

obj = re.compile(r'<li>.*?<span class="title">(?P<name>.*?)</span>.*?'
                 r'<br>(?P<year>.*?)&nbsp.*?'
                 r'<span class="rating_num" property="v:average">(?P<score>.*?)</span>.*?'
                 r'<span>(?P<num>.*?)人评价</span>.*?', re.S)
result = obj.finditer(resp.text)

f = open("data.csv", mode="w")
csvwriter = csv.writer(f)

for i in result:
    dic = i.groupdict()
    dic['year'] = dic['year'].strip()
    csvwriter.writerow(dic.values())
f.close()
print("over!")