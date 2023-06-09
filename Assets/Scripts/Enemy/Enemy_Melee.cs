using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Melee : Enemy
{
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        enemyAnim = GetComponent<Animator>();
        healthSystem = GetComponent<HealthSystem>();
        healthSystem.MaxHealth = enemyConfig.Health;
        points = enemyConfig.Points;
        speed = enemyConfig.Speed;
        distanceDetection = enemyConfig.DistanceDetection;
        distanceStop = enemyConfig.DistanceStop;
        distanceAttack = enemyConfig.DistanceAttack;
    }
    private void Update()
    {
        Move();
    }
    protected override void Move()
    {
        base.Move();
    }

    protected override void Attack()
    {
        base.Attack();
        //activo animacion ataque, el que va a generar da�o es el collider del arma
    }

    public override void Dead()
    {
        base.Dead();
    }
}