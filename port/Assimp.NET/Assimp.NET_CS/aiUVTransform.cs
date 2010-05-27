/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class aiUVTransform : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal aiUVTransform(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(aiUVTransform obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~aiUVTransform() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          Assimp_NETPINVOKE.delete_aiUVTransform(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public aiVector2D mTranslation {
    set {
      Assimp_NETPINVOKE.aiUVTransform_mTranslation_set(swigCPtr, aiVector2D.getCPtr(value));
    } 
    get {
      IntPtr cPtr = Assimp_NETPINVOKE.aiUVTransform_mTranslation_get(swigCPtr);
      aiVector2D ret = (cPtr == IntPtr.Zero) ? null : new aiVector2D(cPtr, false);
      return ret;
    } 
  }

  public aiVector2D mScaling {
    set {
      Assimp_NETPINVOKE.aiUVTransform_mScaling_set(swigCPtr, aiVector2D.getCPtr(value));
    } 
    get {
      IntPtr cPtr = Assimp_NETPINVOKE.aiUVTransform_mScaling_get(swigCPtr);
      aiVector2D ret = (cPtr == IntPtr.Zero) ? null : new aiVector2D(cPtr, false);
      return ret;
    } 
  }

  public float mRotation {
    set {
      Assimp_NETPINVOKE.aiUVTransform_mRotation_set(swigCPtr, value);
    } 
    get {
      float ret = Assimp_NETPINVOKE.aiUVTransform_mRotation_get(swigCPtr);
      return ret;
    } 
  }

  public aiUVTransform() : this(Assimp_NETPINVOKE.new_aiUVTransform(), true) {
  }

}
