using Assets.Scripts.Buy;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSpaceShip : MonoBehaviour
{
    public GameObject SpaceShip_1, SpaceShip_2, SpaceShip_3, SpaceShip_4, SpaceShip_5, SpaceShip_6, SpaceShip_7, SpaceShip_8, SpaceShip_9;
    public GameObject checmark1, checmark2, checmark3, checmark4, checmark5, checmark6, checmark7, checmark8, checmark9;

    List<BuySS> purchases;

    private void Start()
    {
        purchases = new List<BuySS>
        {
            new BuySS1(),
            new BuySS2(),
            new BuySS3(),
            new BuySS4(),
            new BuySS5(),
            new BuySS6(),
            new BuySS7(),
            new BuySS8(),
            new BuySS9(),
        };
    }

    private void Update()
    {
        if (Selected.selectedSpaceShip == 1 && purchases[0].isBoughtSS)
        {
            SpaceShip_1.SetActive(true);
            SpaceShip_2.SetActive(false);
            SpaceShip_3.SetActive(false);
            SpaceShip_4.SetActive(false);
            SpaceShip_5.SetActive(false);
            SpaceShip_6.SetActive(false);
            SpaceShip_7.SetActive(false);
            SpaceShip_8.SetActive(false);
            SpaceShip_9.SetActive(false);

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

        else if (Selected.selectedSpaceShip == 2 && purchases[1].isBoughtSS)
        {
            SpaceShip_1.SetActive(false);
            SpaceShip_2.SetActive(true);
            SpaceShip_3.SetActive(false);
            SpaceShip_4.SetActive(false);
            SpaceShip_5.SetActive(false);
            SpaceShip_6.SetActive(false);
            SpaceShip_7.SetActive(false);
            SpaceShip_8.SetActive(false);
            SpaceShip_9.SetActive(false);

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

        else if (Selected.selectedSpaceShip == 3 && purchases[2].isBoughtSS)
        {
            SpaceShip_1.SetActive(false);
            SpaceShip_2.SetActive(false);
            SpaceShip_3.SetActive(true);
            SpaceShip_4.SetActive(false);
            SpaceShip_5.SetActive(false);
            SpaceShip_6.SetActive(false);
            SpaceShip_7.SetActive(false);
            SpaceShip_8.SetActive(false);
            SpaceShip_9.SetActive(false);

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

        else if (Selected.selectedSpaceShip == 4 && purchases[3].isBoughtSS)
        {
            SpaceShip_1.SetActive(false);
            SpaceShip_2.SetActive(false);
            SpaceShip_3.SetActive(false);
            SpaceShip_4.SetActive(true);
            SpaceShip_5.SetActive(false);
            SpaceShip_6.SetActive(false);
            SpaceShip_7.SetActive(false);
            SpaceShip_8.SetActive(false);
            SpaceShip_9.SetActive(false);

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

        else if (Selected.selectedSpaceShip == 5 && purchases[4].isBoughtSS)
        {
            SpaceShip_1.SetActive(false);
            SpaceShip_2.SetActive(false);
            SpaceShip_3.SetActive(false);
            SpaceShip_4.SetActive(false);
            SpaceShip_5.SetActive(true);
            SpaceShip_6.SetActive(false);
            SpaceShip_7.SetActive(false);
            SpaceShip_8.SetActive(false);
            SpaceShip_9.SetActive(false);

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

        else if (Selected.selectedSpaceShip == 6 && purchases[5].isBoughtSS)
        {
            SpaceShip_1.SetActive(false);
            SpaceShip_2.SetActive(false);
            SpaceShip_3.SetActive(false);
            SpaceShip_4.SetActive(false);
            SpaceShip_5.SetActive(false);
            SpaceShip_6.SetActive(true);
            SpaceShip_7.SetActive(false);
            SpaceShip_8.SetActive(false);
            SpaceShip_9.SetActive(false);

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

        else if (Selected.selectedSpaceShip == 7 && purchases[6].isBoughtSS)
        {
            SpaceShip_1.SetActive(false);
            SpaceShip_2.SetActive(false);
            SpaceShip_3.SetActive(false);
            SpaceShip_4.SetActive(false);
            SpaceShip_5.SetActive(false);
            SpaceShip_6.SetActive(false);
            SpaceShip_7.SetActive(true);
            SpaceShip_8.SetActive(false);
            SpaceShip_9.SetActive(false);

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

        else if (Selected.selectedSpaceShip == 8 && purchases[7].isBoughtSS)
        {
            SpaceShip_1.SetActive(false);
            SpaceShip_2.SetActive(false);
            SpaceShip_3.SetActive(false);
            SpaceShip_4.SetActive(false);
            SpaceShip_5.SetActive(false);
            SpaceShip_6.SetActive(false);
            SpaceShip_7.SetActive(false);
            SpaceShip_8.SetActive(true);
            SpaceShip_9.SetActive(false);

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

        else if (Selected.selectedSpaceShip == 9 && purchases[8].isBoughtSS)
        {        
            SpaceShip_1.SetActive(false);
            SpaceShip_2.SetActive(false);
            SpaceShip_3.SetActive(false);
            SpaceShip_4.SetActive(false);
            SpaceShip_5.SetActive(false);
            SpaceShip_6.SetActive(false);
            SpaceShip_7.SetActive(false);
            SpaceShip_8.SetActive(false);
            SpaceShip_9.SetActive(true);

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
