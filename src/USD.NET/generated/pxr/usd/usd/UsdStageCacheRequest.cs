//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace pxr {

public class UsdStageCacheRequest : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UsdStageCacheRequest(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdStageCacheRequest obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UsdStageCacheRequest() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_UsdStageCacheRequest(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual bool IsSatisfiedBy(UsdStage stage) {
    bool ret = UsdCsPINVOKE.UsdStageCacheRequest_IsSatisfiedBy__SWIG_0(swigCPtr, UsdStage.getCPtr(stage));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool IsSatisfiedBy(UsdStageCacheRequest pending) {
    bool ret = UsdCsPINVOKE.UsdStageCacheRequest_IsSatisfiedBy__SWIG_1(swigCPtr, UsdStageCacheRequest.getCPtr(pending));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual UsdStage Manufacture() {
    global::System.IntPtr cPtr = UsdCsPINVOKE.UsdStageCacheRequest_Manufacture(swigCPtr);
    UsdStage ret = (cPtr == global::System.IntPtr.Zero) ? null : new UsdStage(cPtr, true);
    return ret;
  }

}

}
