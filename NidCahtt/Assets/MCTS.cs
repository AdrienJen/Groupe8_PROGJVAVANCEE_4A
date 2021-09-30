using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MCTS
{
    private MCTS parent;
    public List<MCTS> child;
    public List<MCTS> availableMoves;
    private int boardMinX = -15;
    private int boardMaxX = 15;
    private int p1RandomPosX = -5;
    private int p1RandomPosY = -7;
    private int p1RandomPosWeaponX = -4;
    private int p1RandomPosWeaponY = -6;
    private int p2MCTSPosX = 5;
    private int p2MCTSPosY = -7;
    private int p2MCTSPosWeaponX = 4;
    private int p2MCTSPosWeaponY = -6;
    private int jump = 4;
    private int numberOfMove=4;
    private int actualMove;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void ComputeMCTS()
    {
        int max = 20;
        for(actualMove=1;actualMove<=numberOfMove;actualMove++)
        {
            for (int x = 1; x <= 20; x++)
            {
                if (actualMove == 1)
                {
                    p2MCTSPosX -= 2;
                    p2MCTSPosWeaponX = p2MCTSPosX -1;
                    if (p2MCTSPosX <= boardMinX)
                    {
                        p2MCTSPosX = boardMinX;
                    }
                }
                
                if (actualMove == 2)
                {
                    p2MCTSPosX += 2;
                    p2MCTSPosWeaponX = p2MCTSPosX +1;
                    if (p2MCTSPosX >= boardMaxX)
                    {
                        p2MCTSPosX = boardMaxX;
                    }
                }
                if (actualMove == 3)
                {
                   
                    //Après 1 seconde augmente p2MCTSPosY de 4
                    //while p2MCTSPosY <  p2MCTSPosY+4  ;
                    p2MCTSPosY += 4;
                    
                    p2MCTSPosWeaponY = p2MCTSPosY + 1;
                    //Après 1 seconde baisse p2MCTSPosY de 4 
                    //while p2MCTSPosY >  p2MCTSPosY-4  ;
                    
                    p2MCTSPosY -= 4;
                    
                    
                }

                
            }
            
        }
      

    }

    void Move(int moveSet)
    {
        if (moveSet == 1)
        {
            
        }
    }
    
}
