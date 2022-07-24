#!/usr/bin/env python
# -*- coding: utf-8 -*-
# Just PyThon3 !! 0xtn+JohanV
import colorama,requests,os,sys,re,threading,concurrent.futures,json,webbrowser
from colorama import *
try:
 os.system("title @DXDTEAM Checkers | More : t.me/dxdteam ")
except:pass
init(autoreset=True)
fr = Fore.RED
fb = Fore.BLUE
fc = Fore.CYAN
fw = Fore.WHITE
fy = Fore.YELLOW
fg = Fore.GREEN
try:
    os.mkdir('dxdteam-rzlt')
except:
    pass

try:
    if os.name == 'nt':os.system('cls')
    else:os.system('clear')
except:
        pass
live,die,total=0,0,0
somech=['DxDteam','Bounce','Amazon','Office365','PayPal']
status_=['live','die']
def status(x,y,z):
    global live 
    global die
    if z==0:
        live+=1
        ff=fg
    else:
        die+=1
        ff=fr
    print(f"{fb} [{fg}{live}/{fr}{die}/{fw}{total}{fb}] {ff}{x} | {fb}[ {ff}{somech[y]} Checker {fb}]{fw}")
    try:
        os.system(f'title [{live}/{die}/{total}] | {somech[y]} Checker By {somech(0)}')
    except:pass
    open('dxdteam-rzlt/%s_%s.txt'%(somech[y].lower(),status_[z]), 'a').write(f'{x}\n')

def off(i):
    data = '{"username":"' + i + '"}'
    x = requests.post('https://login.microsoftonline.com/common/GetCredentialType?mkt=en-US', data=data).text
    resp = json.loads(x)
    cek = resp['IfExistsResult']
    valid = resp['IsSignupDisallowed']
    if cek == 0 and valid == True:status(i,3,0)
    else:status(i,3,1)

def bon(i):
     headers = {'user-agent':'Linux Mozilla 5/0','Accept-Encoding':'none'}
     payload = {'emailToValidate':str(i),'actionName':'nc_signup'}
     aa = requests.post('https://www.namecheap.com/Cart/ajax/Validation.ashx', headers=headers, data=payload).json()
     if aa['IsValid']:status(i,1,0)
     else:status(i,1,1)

def ama(i):    
    link = "https://www.amazon.com/ap/register%3Fopenid.assoc_handle%3Dsmallparts_amazon%26openid.identity%3Dhttp%253A%252F%252Fspecs.openid.net%252Fauth%252F2.0%252Fidentifier_select%26openid.ns%3Dhttp%253A%252F%252Fspecs.openid.net%252Fauth%252F2.0%26openid.claimed_id%3Dhttp%253A%252F%252Fspecs.openid.net%252Fauth%252F2.0%252Fidentifier_select%26openid.return_to%3Dhttps%253A%252F%252Fwww.smallparts.com%252Fsignin%26marketPlaceId%3DA2YBZOQLHY23UT%26clientContext%3D187-1331220-8510307%26pageId%3Dauthportal_register%26openid.mode%3Dcheckid_setup%26siteState%3DfinalReturnToUrl%253Dhttps%25253A%25252F%25252Fwww.smallparts.com%25252Fcontactus%25252F187-1331220-8510307%25253FappAction%25253DContactUsLanding%252526pf_rd_m%25253DA2LPUKX2E7NPQV%252526appActionToken%25253DlptkeUQfbhoOU3v4ShyMQLid53Yj3D%252526ie%25253DUTF8%252Cregist%253Dtrue"
    head = {'User-agent':'Mozilla/5.0 (Linux; U; Android 4.4.2; en-US; HM NOTE 1W Build/KOT49H) AppleWebKit/534.30 (KHTML, like Gecko) Version/4.0 UCBrowser/11.0.5.850 U3/0.8.0 Mobile Safari/534.30'}
    s = requests.session()
    g = s.get(link, headers=head)
    xxx = {'customerName':'ouss0xtn','email': i,'emailCheck': i,'password':'dxdteam','passwordCheck':'dxdteam'}
    cek = s.post(link, headers=head, data=xxx).text
    if "You indicated you are a new customer, but an account already exists with the e-mail" in cek:status(i,2,0)
    else:status(i,2,1)

def pay(i):
    email = i
    url = 'https://www.paypal.com/cgi-bin/webscr'
    headers = {
        'user-agent': 'Mozilla/5.0 (Windows NT 6.3) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36'
    }
    data = {
        'cmd': ' _cart ',
        'upload': ' 1 ',
        'business': ' indre@robertkalinkin.com ',
        'item_name_1': 'RK GIFT BOX/1',
        'item_number_1': '',
        'amount_1': ' 81.82',
        'quantity_1': ' 1',
        'weight_1': ' 0',
        'on0_1': ' Size - letters',
        'os0_1': ' S',
        'on1_1': ' Color',
        'os1_1': ' GRY/WH/WH',
        'item_name_2': ' Shipping, Handling, Discounts & Taxes',
        'item_number_2': ' ',
        'amount_2': ' 17.18',
        'quantity_2': ' 1',
        'weight_2': ' 0',
        'currency_code': ' EUR',
        'first_name': ' James Warner',
        'last_name': ' ',
        'address1': ' 3881 Yorkland Dr. NW Apt. 8',
        'address2': ' ',
        'city': ' Comstock Park',
        'zip': ' 49321',
        'country': ' US',
        'address_override': ' 0',
        'email': i,  
    }
    req = requests.post(url, data=data, headers=headers).text;cc=0
    while 'your last action could not be completed' in req and cc<3: 
        req = requests.post(url, data=data, headers=headers).text;cc+=1
    if 'your last action could not be completed' in req:status(i,4,1)
    else:status(i,4,0)

def abot():
 sys.exit(fw+"""
 [Tool] DxdTeam Checkers 
 [owner] Oussama Escanor(0xtn) >> t.me/exploitn
 [owner] Johan Vestige >> t.me/JohanVestige
 [Our Links]
  ~Channel https://t.me/dxdteam
  ~Group : https://t.me/dxdfamily
  ~Online Store : https://shoppy.gg/@dxxd (just contact us directly)
 """);webbrowser.open('http://t.me/dxdteam')
DxD=[bon,ama,off,pay,abot]
choice = input(f"""{fb}  
888~-_                  888 ~~~888~~~                                   
888   \  Y88b  /   e88~\888    888     e88~~8e    /~~~8e  888-~88e-~88e 
888    |  Y88b/   d888  888    888    d888  88b       88b 888  888  888 {fr}
888    |   Y88b   8888  888    888    8888__888  e88~-888 888  888  888 
888   /    /Y88b  Y888  888    888    Y888    , C888  888 888  888  888 
888_-~    /  Y88b  "88_/888    888     "88___/   "88_-888 888  888  888 
    \033[90m~ For more tools : t.me/dxdteam | t.me/shop_unknows~
    Ps: Proxyless !!
    {fb}1{fw}//{fb}[{fg} Bounce Checker {fb}] 
    {fb}2{fw}//{fb}[{fg} Amazon Checker {fb}]
    {fb}3{fw}//{fb}[{fg} Office Checker {fb}]
    {fb}4{fw}//{fb}[{fg} PayPal Checker {fb}]
    {fb}5{fw}//{fb}[{fg} About us       {fb}]      
        
{fy}dxdteam >> {fw}""")
if int(choice) not in range(1,6):exit(f"{fr}You must type a number from 1 to 5 !\n\tPlease try again{fw}")
if choice=='5':DxD[4]()
else:
 mails = open(input(f'{fy}Maillist >> {fw}'), 'r',errors='ignore').read().splitlines()
 #filtre emails + remove duplicates
 mails = list(dict.fromkeys((re.findall('[\w\.=-]+@[\w\.-]+\.[\w]{2,3}', str(mails)))))
 total=len(mails)
 threads = []
 try:
    with concurrent.futures.ThreadPoolExecutor(10) as executor:
        executor.map(DxD[int(choice)-1], mails)
 except Exception as e:
    print(e)
#For You Merlin