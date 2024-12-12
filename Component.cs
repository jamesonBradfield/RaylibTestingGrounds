using Raylib_cs;
using ImGuiNET;
namespace Engine {
public class Component {
  protected string name;
  protected GameObject _gameObject;
  public GameObject gameObject {
    set { _gameObject = value; }
    get { return _gameObject; }
  }
  public virtual void Draw(Camera2D? camera) {}
  public virtual void Draw(Camera3D? camera) {}
  public virtual void DrawInspector() {}
  public virtual void EarlyUpdate() {}
  public virtual void Update() {}
  public virtual void LateUpdate() {}
  public virtual void Initialize() {}
}
}
