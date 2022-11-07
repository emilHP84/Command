using System;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

    public int speed;
    public float speedInfinity;
    
    public GameObject CanonOut;
    public GameObject AmmoPrefab;
    public GameObject Light;
    public GameObject Ui;
    public GameObject CubeInfinity;
    public GameObject Ground;
    
    public bool leftHandActive;
    public Animator anim;

    private readonly Stack<CommandCube> _cubeCommands = new Stack<CommandCube>();
    private readonly Stack<CommandEvironment> _bulletCommand = new Stack<CommandEvironment>();

    private void Start()
    {
        anim = GetComponent<Animator>();
        Light.SetActive(false);
        Ui.SetActive(false);
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.A))
        {
            LeftCommandHand leftCommandHand = new LeftCommandHand();
            leftCommandHand.Do(this);
            _cubeCommands.Push(leftCommandHand);
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            UiActivating uiActivating = new UiActivating();
            uiActivating.Do(this);
            _cubeCommands.Push(uiActivating);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            ChangeColor changeColor = new ChangeColor();
            changeColor.Do(this);
            _cubeCommands.Push(changeColor);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ChangePosition changePosition = new ChangePosition();
            changePosition.Do(this);
            _cubeCommands.Push(changePosition);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            ChangeRotation changeRotation = new ChangeRotation();
            changeRotation.Do(this);
            _cubeCommands.Push(changeRotation);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            ChangeLocalScale changeLocalScale = new ChangeLocalScale();
            changeLocalScale.Do(this);
            _cubeCommands.Push(changeLocalScale);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            LightActivating lightActivating = new LightActivating();
            lightActivating.Do(this);
            _cubeCommands.Push(lightActivating);
        }
        if (Input.GetKeyDown(KeyCode.X))
        { 
            AnimationActivating animationActivating = new AnimationActivating();
            animationActivating.Do(this);
            _cubeCommands.Push(animationActivating);
        }
        if (Input.GetKeyDown(KeyCode.C)){
            BlocInfintyForward blocInfintyForward = new BlocInfintyForward();
            blocInfintyForward.Do(this);
            _cubeCommands.Push(blocInfintyForward);
        }
        if (Input.GetKeyDown(KeyCode.V))
        { 
            ChangeOpacity changeOpacity = new ChangeOpacity();
            changeOpacity.Do(this);
            _cubeCommands.Push(changeOpacity);
        }
        
        
        /*if (Input.GetAxis("Vertical") != 0) {
            float horizontal = Input.GetAxis("Vertical") * Time.deltaTime;
            VerticalCommand verticalCommand = new VerticalCommand(horizontal);
            verticalCommand.Do(this);
            _commands.Push(verticalCommand);
        }*/
         if (Input.GetKeyDown(KeyCode.UpArrow)) {
             ForwardCommandCube forwardCommandCube = new ForwardCommandCube();
             forwardCommandCube.Do(this);
             _cubeCommands.Push(forwardCommandCube);
         }
         if (Input.GetKeyDown(KeyCode.DownArrow)) {
             BackwardCommandCube backwardCommandCube = new BackwardCommandCube();
             backwardCommandCube.Do(this);
             _cubeCommands.Push(backwardCommandCube);
         }
        /*if (Input.GetAxis("Horizontal") != 0) {
            float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime;
            HorizontalCommandCube horizontalCommand = new HorizontalCommandCube(horizontal);
            horizontalCommand.Do(this);
            _cubeCommands.Push(horizontalCommand);
        }*/
         if (Input.GetKeyDown(KeyCode.RightArrow)) {
             RightCommandCube rightCommandCube = new RightCommandCube();
             rightCommandCube.Do(this);
             _cubeCommands.Push(rightCommandCube);
         }
         if (Input.GetKeyDown(KeyCode.LeftArrow)) {
             LeftCommandCube leftCommandCube = new LeftCommandCube();
             leftCommandCube.Do(this);
             _cubeCommands.Push(leftCommandCube);
         }
         
         

        if (Input.GetKeyDown(KeyCode.Space) && _cubeCommands.Count > 0) {
            CommandCube commandCube = _cubeCommands.Pop();
            commandCube.Undo(this);
        }
        
    }
    
}