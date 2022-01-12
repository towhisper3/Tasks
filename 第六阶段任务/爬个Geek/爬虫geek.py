import re
import codecs
import requests

url = "http://212.129.245.115:8080/static/js/app.7149a871ab46e4d1cdd7.js"
headers = {"User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/94.0.4606.81 Safari/537.36"}
obj1 = re.compile(r'\[(t|this)._v\((\'|\")(?P<t>.*?)(\'|\")\).*?', re.S) # 文字的正则
obj2 = re.compile(r'src:"(?P<src>.*?)(",alt:"|)"}.*?', re.S) # 图片链接的正则


resp = requests.get(url=url, headers=headers)

f = codecs.open("data.txt", mode="a", encoding='utf-8')

result1 = obj1.finditer(resp.text)
for it in result1:
    dic = it.groupdict()
    f.writelines(dic.values())
    f.writelines('\n')
f.close()

result2 = obj2.finditer(resp.text)
for it in result2:
    img_src = it.group('src')
    img_resp = requests.get(img_src)
    img_name = img_src.split('/')[-1]
    with open("img/"+img_name, mode='wb') as f:
        f.write(img_resp.content)
        f.close()
        print("over!", img_name)
print("all over!!!")
