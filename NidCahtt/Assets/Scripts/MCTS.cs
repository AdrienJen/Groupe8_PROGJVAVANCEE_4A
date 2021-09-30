using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MCTS
{
    
    public List<String> MovesList;
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
    private float timerLeft = 60f;
    int win = 0;
    int lose = 0;
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
            Move();
            for (int x = 1; x <= 20; x++)
            { 
                
                timerLeft -= Time.deltaTime;
                while (timerLeft>0)
                {
                    Move();
                }

                if (timerLeft <= 0)
                {
                    lose =+ 1;
                }
            }
            
            
        }
      

    }

    void Move()
    {
        if (actualMove == 1)
        {
            string actualMove = "moveLeft";
            p2MCTSPosX -= 2;
            p2MCTSPosWeaponX = p2MCTSPosX -1;
            if (p2MCTSPosX <= boardMinX)
            {
                p2MCTSPosX = boardMinX;
            }
            MovesList.Add(actualMove);
        }
                
        if (actualMove == 2)
        {
            string actualMove = "moveRight";
            p2MCTSPosX += 2;
            p2MCTSPosWeaponX = p2MCTSPosX +1;
            if (p2MCTSPosX >= boardMaxX)
            {
                p2MCTSPosX = boardMaxX;
            }
            MovesList.Add(actualMove);
        }
        if (actualMove == 3)
        {
            string actualMove = "Jump";
            //Après 1 seconde augmente p2MCTSPosY de 4
            //while p2MCTSPosY <  p2MCTSPosY+4  ;
            p2MCTSPosY += 4;
                    
            p2MCTSPosWeaponY = p2MCTSPosY + 1;
            //Après 1 seconde baisse p2MCTSPosY de 4 
            //while p2MCTSPosY >  p2MCTSPosY-4  ;
                    
            p2MCTSPosY -= 4;
            
            MovesList.Add(actualMove);
                    
                    
        }

        if (p1RandomPosX - 1 <= p2MCTSPosWeaponX && p2MCTSPosWeaponX <= p1RandomPosX + 1)
        {
            if (p1RandomPosY - 1 <= p2MCTSPosWeaponY && p2MCTSPosY <= p2MCTSPosWeaponY + 1)
            {
                win += 1;
            }
        }

    }
    
}
