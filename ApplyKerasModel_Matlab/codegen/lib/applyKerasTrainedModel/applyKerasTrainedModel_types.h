/*
 * applyKerasTrainedModel_types.h
 *
 * Code generation for function 'applyKerasTrainedModel'
 *
 */

#ifndef __APPLYKERASTRAINEDMODEL_TYPES_H__
#define __APPLYKERASTRAINEDMODEL_TYPES_H__

/* Include files */
#include "rtwtypes.h"

/* Type Definitions */
#ifndef struct_emxArray__common
#define struct_emxArray__common
struct emxArray__common
{
    void *data;
    int *size;
    int allocatedSize;
    int numDimensions;
    boolean_T canFreeData;
};
#endif /*struct_emxArray__common*/
#ifndef struct_emxArray_real_T
#define struct_emxArray_real_T
struct emxArray_real_T
{
    double *data;
    int *size;
    int allocatedSize;
    int numDimensions;
    boolean_T canFreeData;
};
#endif /*struct_emxArray_real_T*/

#endif
/* End of code generation (applyKerasTrainedModel_types.h) */
