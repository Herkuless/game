using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blau_controller : MonoBehaviour
{
  Animator animator;
  SpriteRenderer spriteRenderer;
  Rigidbody2D rb2d;

  PlayerInputActions input;
  float movement;
  float jump;

  public follow follow;
  public float distance;

  [SerializeField]
  Transform groundcheck;

  public bool onground;
  public float speed,thrust;

    void Awake(){
      input = new PlayerInputActions();
      input.blau.move.performed += ctx => movement = ctx.ReadValue<float>();
      input.blau.jump.performed += ctx => jump = ctx.ReadValue<float>();
    }
    // Start is called before the first frame update
    void Start(){
      rb2d = GetComponent<Rigidbody2D>();
      animator = GetComponent<Animator>();
      spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate() {
      if(follow.getWinner() == "none" || follow.getWinner() == "blau") Move();
      if(follow.getWinner() == "blau") animator.Play("blau_jump");
      else Animate();

      if(Physics2D.Linecast(transform.position,groundcheck.position,1 << LayerMask.NameToLayer("ground")) || Physics2D.Linecast(transform.position,groundcheck.position,1 << LayerMask.NameToLayer("rot"))) onground = true;
      else onground = false;
    }

    void Move(){
      //walk
      rb2d.velocity = new Vector2(movement*speed,rb2d.velocity.y);
      //jump
      if(onground && jump > 0) {
        rb2d.velocity = new Vector2(rb2d.velocity.x,jump * thrust);
      }
    }
    void Animate(){
      //walk animation
      if(rb2d.velocity.x != 0 && onground) animator.Play("blau_walk");
      //jump animation
      else if(!onground) animator.Play("blau_jump");
      //idle animation
      else animator.Play("blau_idle");
    }

    private void OnEnable(){
      input.Enable();
    }
    private void OnDisable(){
      input.Disable();
    }
}
