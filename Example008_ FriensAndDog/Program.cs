double speed_1 = 2, speed_2 = 3, speed_d = 5;
double distance = 10000;
double time = 0;
bool it_is_friend_1 = false;
int count = 0;

while(distance>10)
{
    if(it_is_friend_1)
    {
        time = distance/(speed_1 + speed_d);
        it_is_friend_1 =false;
    }
    else
    {
        time = distance/(speed_2 + speed_d);
        it_is_friend_1 =true;
    }
    distance = distance - (speed_1 + speed_2) * time;
    count++;
}
Console.WriteLine(count);
