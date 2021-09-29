using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MCTS
{
    private MCTS parent;
    public List<MCTS> child;
    public List<MCTS> availableMoves;
    
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
