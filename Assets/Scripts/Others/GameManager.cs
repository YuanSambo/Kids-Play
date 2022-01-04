using Others;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;



public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int rounds = 3;
 
    private int _roundCorrect;
    private SceneData sceneData;

    private void Awake()
    {
        var sceneName = SceneManager.GetActiveScene().name;
        sceneData = SceneDataHandler.LoadSceneData(sceneName);

        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    [SerializeField] private UnityEvent onStart;

    private void Start()
    {
        onStart?.Invoke();
    }

    protected void Update()
    {
        if (_roundCorrect >= rounds)
        {
            RoundWin();
        }
        
        SceneDataHandler.SaveSceneData(sceneData);
    }

    [SerializeField] private UnityEvent onCorrectAnswer;

    public void CorrectAnswer()
    {
        sceneData.correct++;
        _roundCorrect++;
        SoundManager.Instance.Play("Sparkle");
        onCorrectAnswer?.Invoke();
    }


    [SerializeField] private UnityEvent onWrongAnswer;

    public void WrongAnswer()
    {
        sceneData.wrong++;
        onWrongAnswer?.Invoke();
    }

    [SerializeField] private UnityEvent onRoundWin;

    private void RoundWin()
    {
        onRoundWin?.Invoke();
        SoundManager.Instance.PlayWithDelay("GreatJob", 0.5f);
        Reset();
    }

    private void Reset()
    {
        _roundCorrect = 0;
    }
}