/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class IOSystem : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal IOSystem(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(IOSystem obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~IOSystem() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          Assimp_NETPINVOKE.delete_IOSystem(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public bool Exists(string pFile) {
    bool ret = Assimp_NETPINVOKE.IOSystem_Exists__SWIG_0(swigCPtr, pFile);
    if (Assimp_NETPINVOKE.SWIGPendingException.Pending) throw Assimp_NETPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual char getOsSeparator() {
    char ret = Assimp_NETPINVOKE.IOSystem_getOsSeparator(swigCPtr);
    return ret;
  }

  public virtual IOStream Open(string pFile, string pMode) {
    IntPtr cPtr = Assimp_NETPINVOKE.IOSystem_Open__SWIG_0(swigCPtr, pFile, pMode);
    IOStream ret = (cPtr == IntPtr.Zero) ? null : new IOStream(cPtr, false);
    return ret;
  }

  public virtual IOStream Open(string pFile) {
    IntPtr cPtr = Assimp_NETPINVOKE.IOSystem_Open__SWIG_1(swigCPtr, pFile);
    IOStream ret = (cPtr == IntPtr.Zero) ? null : new IOStream(cPtr, false);
    return ret;
  }

  public virtual void Close(IOStream pFile) {
    Assimp_NETPINVOKE.IOSystem_Close(swigCPtr, IOStream.getCPtr(pFile));
  }

  public virtual bool ComparePaths(string one, string second) {
    bool ret = Assimp_NETPINVOKE.IOSystem_ComparePaths__SWIG_0(swigCPtr, one, second);
    return ret;
  }

}
