using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rot_controller : MonoBehaviour
{
  Animator animator;
  SpriteRenderer spriteRenderer;
  Rigidbody2D rb2d;

  PlayerInputActions input;
  float movement;
  float jump;

    public new follow follow;

    [SerializeField]
  Transform groundcheck;

  public bool onground;
  public float speed,thrust;

    void Awake(){
      input = new PlayerInputActions();
      input.rot.move.performed += ctx => movement = ctx.ReadValue<float>();
      input.rot.jump.performed += ctx => jump = ctx.ReadValue<float>();
    }
    // Start is called before the first frame update
    void Start(){
      rb2d = GetComponent<Rigidbody2D>();
      animator = GetComponent<Animator>();
      spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate() {
      if (follow.rot_winning()) Move();

      if(Physics2D.Linecast(transform.position,groundcheck.position,1 << LayerMask.NameToLayer("ground"))) onground = true;
      else onground = false;
    }

    void Move(){
      //walk
      rb2d.velocity = new Vector2(movement*speed,rb2d.velocity.y);
      //walk animation
      if(rb2d.velocity.x != 0 && onground) animator.Play("rot_walk");
      //jump animation
      else if(!onground) animator.Play("rot_jump");
      //idle animation
      else animator.Play("rot_idle");
      //jump
      if(onground && jump > 0) {
        rb2d.velocity = new Vector2(rb2d.velocity.x,jump * thrust);
      }
    }

    void OnTriggerStay2D(){
      onground = true;
    }
    void OnTriggerExit2D(){
      onground = false;
    }

    private void OnEnable(){
      input.Enable();
    }
    private void OnDisable(){
      input.Disable();
    }
}