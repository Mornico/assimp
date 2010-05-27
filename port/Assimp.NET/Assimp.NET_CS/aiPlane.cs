/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class aiPlane : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal aiPlane(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(aiPlane obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~aiPlane() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          Assimp_NETPINVOKE.delete_aiPlane(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public aiPlane() : this(Assimp_NETPINVOKE.new_aiPlane__SWIG_0(), true) {
  }

  public aiPlane(float _a, float _b, float _c, float _d) : this(Assimp_NETPINVOKE.new_aiPlane__SWIG_1(_a, _b, _c, _d), true) {
  }

  public aiPlane(aiPlane o) : this(Assimp_NETPINVOKE.new_aiPlane__SWIG_2(aiPlane.getCPtr(o)), true) {
    if (Assimp_NETPINVOKE.SWIGPendingException.Pending) throw Assimp_NETPINVOKE.SWIGPendingException.Retrieve();
  }

  public float a {
    set {
      Assimp_NETPINVOKE.aiPlane_a_set(swigCPtr, value);
    } 
    get {
      float ret = Assimp_NETPINVOKE.aiPlane_a_get(swigCPtr);
      return ret;
    } 
  }

  public float b {
    set {
      Assimp_NETPINVOKE.aiPlane_b_set(swigCPtr, value);
    } 
    get {
      float ret = Assimp_NETPINVOKE.aiPlane_b_get(swigCPtr);
      return ret;
    } 
  }

  public float c {
    set {
      Assimp_NETPINVOKE.aiPlane_c_set(swigCPtr, value);
    } 
    get {
      float ret = Assimp_NETPINVOKE.aiPlane_c_get(swigCPtr);
      return ret;
    } 
  }

  public float d {
    set {
      Assimp_NETPINVOKE.aiPlane_d_set(swigCPtr, value);
    } 
    get {
      float ret = Assimp_NETPINVOKE.aiPlane_d_get(swigCPtr);
      return ret;
    } 
  }

}
