using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonCreator : MonoBehaviour
{
    public int dungeonWidth, dungeonLengt;
    public int roomWidthMin, roomLengthMin;
    public int maxInterations;
    public int corridorWidth;

    // Start is called before the first frame update
    void Start()
    {
        CreateDungeon();
    }

    private void CreateDungeon()
    {
        DugeonGenerator generator = new DugeonGenerator(dungeonWidth, dungeonLengt);
        var listoOFRooms = generator.CalculateRooms(maxInterations, roomWidthMin, roomLengthMin);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
