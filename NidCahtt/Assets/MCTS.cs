using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MCTS
{
    private MCTS parent;
    public List<MCTS> child;
    public List<MCTS> availableMoves;
    private int boardxmin = -15;
    private int boardmax = 15;
    private int p1randomx = -5;
    private int p1randomy = -7;
    private int p1randomweapon = -4;
    private 
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
        Action bestaction = null;

    }
    
}
