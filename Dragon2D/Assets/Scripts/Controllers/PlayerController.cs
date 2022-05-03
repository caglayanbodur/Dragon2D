using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class PlayerController : MonoBehaviour
{
   private Rigidbody2D _rigidbody2D;
   private Jump _jump;
   private PcInputController _input;
   private bool _isLeftMouseClicked;

   private void Awake()
   {
      _rigidbody2D = GetComponent<Rigidbody2D>();
      _jump = GetComponent<Jump>();
      _input = new PcInputController();
   }

   private void Update()
   {
      if (_input.LeftMouseClickDown)
      {
         _isLeftMouseClicked = true;
      }
   }

   private void FixedUpdate()
   {
      if (_isLeftMouseClicked)
      {
         _jump.JumpAction(_rigidbody2D);
         _isLeftMouseClicked = false;
      }
   }


   private void OnCollisionEnter2D(Collision2D col)
   {
      GameManager.Instance.RestartGame();

   }
}
