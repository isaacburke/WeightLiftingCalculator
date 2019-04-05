"""another_lift="y"

while another_lift=="y":"""

#This is the weight of the bar
"""bar_weight=int(input("Bar Weight: "))"""
bar_weight=int("45")

#This is where the user put in how much weight they want to lift
lift_weight=int(input("How much do you want to lift? "))
print("")

#This is the bar minus the lift weight
minus_bar=lift_weight-bar_weight

#This takes the (weight-bar)/2
one_side=minus_bar//2

#Get the number of 45s
if one_side>=45:
     weight_45=one_side//45
else:
     weight_45="0"
    
#Get the number of 35s
if (one_side%45)>=35:
     weight_35=(one_side%45)//35
else:
    weight_35="0"
    
#Get the number of 25s
if int(one_side%45)>=int(25) or int(weight_35)>=25:
    weight_25=((one_side%45)-(one_side%35))//25
else:
     weight_25="0"
        
"""#Get the number of 15s
    if (one_side%45)>=15 or weight_35>=25 or :
    weight_15=((one_side%45)-(one_side%35)-(one_side%25))//15


#Get the number of 10s
weight_10=((one_side%45)-(one_side%35)-(one_side%25)-(one_side%15))//10
#Get the number of 5s
weight_5=((one_side%45)-(one_side%35)-(one_side%25)-(one_side%15)-\
           (one_side%10))//5
#Get the number of 2.5s
weight_2_5=float(((one_side%45)-(one_side%35)-(one_side%25)-(one_side%15)\
           -(one_side%10)-(one_side%5))//2.5)"""

print("45s:", format(int(weight_45),".0f"))
print("35s:", format(int(weight_35),".0f"))
print("25s:", format(int(weight_25),".0f"))
"""print("15s:", format(weight_15,".0f"))
print("10s:", format(weight_10,".0f"))
print("5s:", format(weight_15,".0f"))
print("2.5s:", format(weight_2_5,".0f"))"""

#Asks user if they have another lift to calculate
"""print("")
another_lift=input("Do you have another lift to calculate (y or n)? ")"""
