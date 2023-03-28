using System;
using System.Collections.Generic;
using UnityEngine;

internal class DugeonGenerator
{
   
    List<RoomNode> allSpaceNodes = new List<RoomNode>();
    private int dungeonWidth;
    private int dungeonLength;
    public DugeonGenerator(int dungeonWidth, int dungeonLengt)
    {
        this.dungeonWidth = dungeonWidth;
        this.dungeonLength = dungeonLengt;
    }

    public List<Node> CalculateRooms(int maxInterations, int roomWidthMin, int roomLengthMin)
    {
        BinarySpacePartitioner bsp = new BinarySpacePartitioner(dungeonWidth, dungeonLength);
        allSpaceNodes = bsp.PrepareNodesCollection(maxInterations, roomWidthMin, roomLengthMin);
        return new List <Node>(allSpaceNodes);
    }
}