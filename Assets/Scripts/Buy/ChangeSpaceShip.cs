using UnityEngine;

public class ChangeSpaceShip : MonoBehaviour
{
    public GameObject SpaceShip_1, SpaceShip_2, SpaceShip_3, SpaceShip_4, SpaceShip_5, SpaceShip_6, SpaceShip_7, SpaceShip_8, SpaceShip_9;
    public GameObject checmark1, checmark2, checmark3, checmark4, checmark5, checmark6, checmark7, checmark8, checmark9;

    private void Update()
    {
        //Проверка для 1 Космического корабля
        if (Selected.selectedSpaceShip == 1 && BuySS1.isboughtSS1 == true)
        {
            //Корабли
            SpaceShip_1.SetActive(true);
            SpaceShip_2.SetActive(false);
            SpaceShip_3.SetActive(false);
            SpaceShip_4.SetActive(false);
            SpaceShip_5.SetActive(false);
            SpaceShip_6.SetActive(false);
            SpaceShip_7.SetActive(false);
            SpaceShip_8.SetActive(false);
            SpaceShip_9.SetActive(false);

            //Галочки
            checmark1.SetActive(true);
            checmark2.SetActive(false);
            checmark3.SetActive(false);
            checmark4.SetActive(false);
            checmark5.SetActive(false);
            checmark6.SetActive(false);
            checmark7.SetActive(false);
            checmark8.SetActive(false);
            checmark9.SetActive(false);
        }

        //Проверка для 2 Космического корабля
        else if (Selected.selectedSpaceShip == 2 && BuySS2.isboughtSS2 == true)
        {
            //Корабли
            SpaceShip_1.SetActive(false);
            SpaceShip_2.SetActive(true);
            SpaceShip_3.SetActive(false);
            SpaceShip_4.SetActive(false);
            SpaceShip_5.SetActive(false);
            SpaceShip_6.SetActive(false);
            SpaceShip_7.SetActive(false);
            SpaceShip_8.SetActive(false);
            SpaceShip_9.SetActive(false);

            //Галочки
            checmark1.SetActive(false);
            checmark2.SetActive(true);
            checmark3.SetActive(false);
            checmark4.SetActive(false);
            checmark5.SetActive(false);
            checmark6.SetActive(false);
            checmark7.SetActive(false);
            checmark8.SetActive(false);
            checmark9.SetActive(false);
        }

        //Проверка для 3 Космического корабля
        else if (Selected.selectedSpaceShip == 3 && BuySS3.isboughtSS3 == true)
        {
            //Корабли
            SpaceShip_1.SetActive(false);
            SpaceShip_2.SetActive(false);
            SpaceShip_3.SetActive(true);
            SpaceShip_4.SetActive(false);
            SpaceShip_5.SetActive(false);
            SpaceShip_6.SetActive(false);
            SpaceShip_7.SetActive(false);
            SpaceShip_8.SetActive(false);
            SpaceShip_9.SetActive(false);

            //Галочки
            checmark1.SetActive(false);
            checmark2.SetActive(false);
            checmark3.SetActive(true);
            checmark4.SetActive(false);
            checmark5.SetActive(false);
            checmark6.SetActive(false);
            checmark7.SetActive(false);
            checmark8.SetActive(false);
            checmark9.SetActive(false);
        }

        //Проверка для 4 Космического корабля
        else if (Selected.selectedSpaceShip == 4 && BuySS4.isboughtSS4 == true)
        {
            //Корабли
            SpaceShip_1.SetActive(false);
            SpaceShip_2.SetActive(false);
            SpaceShip_3.SetActive(false);
            SpaceShip_4.SetActive(true);
            SpaceShip_5.SetActive(false);
            SpaceShip_6.SetActive(false);
            SpaceShip_7.SetActive(false);
            SpaceShip_8.SetActive(false);
            SpaceShip_9.SetActive(false);

            //Галочки
            checmark1.SetActive(false);
            checmark2.SetActive(false);
            checmark3.SetActive(false);
            checmark4.SetActive(true);
            checmark5.SetActive(false);
            checmark6.SetActive(false);
            checmark7.SetActive(false);
            checmark8.SetActive(false);
            checmark9.SetActive(false);
        }

        //Проверка для 5 Космического корабля
        else if (Selected.selectedSpaceShip == 5 && BuySS5.isboughtSS5 == true)
        {
            //Корабли
            SpaceShip_1.SetActive(false);
            SpaceShip_2.SetActive(false);
            SpaceShip_3.SetActive(false);
            SpaceShip_4.SetActive(false);
            SpaceShip_5.SetActive(true);
            SpaceShip_6.SetActive(false);
            SpaceShip_7.SetActive(false);
            SpaceShip_8.SetActive(false);
            SpaceShip_9.SetActive(false);

            //Галочки
            checmark1.SetActive(false);
            checmark2.SetActive(false);
            checmark3.SetActive(false);
            checmark4.SetActive(false);
            checmark5.SetActive(true);
            checmark6.SetActive(false);
            checmark7.SetActive(false);
            checmark8.SetActive(false);
            checmark9.SetActive(false);
        }

        //Проверка для 6 Космического корабля
        else if (Selected.selectedSpaceShip == 6 && BuySS6.isboughtSS6 == true)
        {
            //Корабли
            SpaceShip_1.SetActive(false);
            SpaceShip_2.SetActive(false);
            SpaceShip_3.SetActive(false);
            SpaceShip_4.SetActive(false);
            SpaceShip_5.SetActive(false);
            SpaceShip_6.SetActive(true);
            SpaceShip_7.SetActive(false);
            SpaceShip_8.SetActive(false);
            SpaceShip_9.SetActive(false);

            //Галочки
            checmark1.SetActive(false);
            checmark2.SetActive(false);
            checmark3.SetActive(false);
            checmark4.SetActive(false);
            checmark5.SetActive(false);
            checmark6.SetActive(true);
            checmark7.SetActive(false);
            checmark8.SetActive(false);
            checmark9.SetActive(false);
        }

        //Проверка для 7 Космического корабля
        else if (Selected.selectedSpaceShip == 7 && BuySS7.isboughtSS7 == true)
        {
            //Корабли
            SpaceShip_1.SetActive(false);
            SpaceShip_2.SetActive(false);
            SpaceShip_3.SetActive(false);
            SpaceShip_4.SetActive(false);
            SpaceShip_5.SetActive(false);
            SpaceShip_6.SetActive(false);
            SpaceShip_7.SetActive(true);
            SpaceShip_8.SetActive(false);
            SpaceShip_9.SetActive(false);

            //Галочки
            checmark1.SetActive(false);
            checmark2.SetActive(false);
            checmark3.SetActive(false);
            checmark4.SetActive(false);
            checmark5.SetActive(false);
            checmark6.SetActive(false);
            checmark7.SetActive(true);
            checmark8.SetActive(false);
            checmark9.SetActive(false);
        }

        //Проверка для 8 Космического корабля
        else if (Selected.selectedSpaceShip == 8 && BuySS8.isboughtSS8 == true)
        {
            //Корабли
            SpaceShip_1.SetActive(false);
            SpaceShip_2.SetActive(false);
            SpaceShip_3.SetActive(false);
            SpaceShip_4.SetActive(false);
            SpaceShip_5.SetActive(false);
            SpaceShip_6.SetActive(false);
            SpaceShip_7.SetActive(false);
            SpaceShip_8.SetActive(true);
            SpaceShip_9.SetActive(false);

            //Галочки
            checmark1.SetActive(false);
            checmark2.SetActive(false);
            checmark3.SetActive(false);
            checmark4.SetActive(false);
            checmark5.SetActive(false);
            checmark6.SetActive(false);
            checmark7.SetActive(false);
            checmark8.SetActive(true);
            checmark9.SetActive(false);
        }

        //Проверка для 9 Космического корабля
        else if (Selected.selectedSpaceShip == 9 && BuySS9.isboughtSS9 == true)
        {
            //Корабли
            SpaceShip_1.SetActive(false);
            SpaceShip_2.SetActive(false);
            SpaceShip_3.SetActive(false);
            SpaceShip_4.SetActive(false);
            SpaceShip_5.SetActive(false);
            SpaceShip_6.SetActive(false);
            SpaceShip_7.SetActive(false);
            SpaceShip_8.SetActive(false);
            SpaceShip_9.SetActive(true);

            //Галочки
            checmark1.SetActive(false);
            checmark2.SetActive(false);
            checmark3.SetActive(false);
            checmark4.SetActive(false);
            checmark5.SetActive(false);
            checmark6.SetActive(false);
            checmark7.SetActive(false);
            checmark8.SetActive(false);
            checmark9.SetActive(true);
        }
    }
}

