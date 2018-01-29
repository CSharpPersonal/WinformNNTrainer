/*
 * applyKerasTrainedModel.cpp
 *
 * Code generation for function 'applyKerasTrainedModel'
 *
 */

/* Include files */
#include "rt_nonfinite.h"
#include "applyKerasTrainedModel.h"
#include "sigmoid.h"
#include "applyKerasTrainedModel_emxutil.h"

/* Function Definitions */
double applyKerasTrainedModel(const emxArray_real_T *test_data, const
  emxArray_real_T *weight, const emxArray_real_T *NodesArray)
{
  emxArray_real_T *temp;
  int i0;
  int ar;
  double y;
  double d0;
  int i1;
  emxArray_real_T *b_y;
  int i2;
  emxArray_real_T *C;
  int ib;
  unsigned int unnamed_idx_0;
  int ic;
  int br;
  int ia;
  emxArray_real_T *b_C;
  double cursor;
  int i;
  emxArray_real_T *c_C;
  emxArray_real_T *a;
  emxInit_real_T(&temp, 1);

  /* -------------------------------------------------------------------------- */
  /*  [Output] = applyKerasTrainedModel(test_data,net) */
  /*  */
  /*  applying Keras trained neural network to fit input where: */
  /*    -net: Keras Neural Network Object as numpy array (2 layers) */
  /*    -Input: Testing Input */
  /*   */
  /*  based on Keras with Tensorflow, python 3.6, all activation function uses */
  /*  sigmoid (copy sigmoid.m together with this file for use elsewhere) */
  /* -------------------------------------------------------------------------- */
  i0 = temp->size[0];
  temp->size[0] = test_data->size[1];
  emxEnsureCapacity((emxArray__common *)temp, i0, (int)sizeof(double));
  ar = test_data->size[1];
  for (i0 = 0; i0 < ar; i0++) {
    temp->data[i0] = test_data->data[test_data->size[0] * i0];
  }

  y = (1.0 + (double)test_data->size[1] * NodesArray->data[0]) - 1.0;
  if (1.0 > y) {
    i0 = 0;
  } else {
    i0 = (int)y;
  }

  y = 1.0 + (double)test_data->size[1] * NodesArray->data[0];
  d0 = ((1.0 + (double)test_data->size[1] * NodesArray->data[0]) +
        NodesArray->data[0]) - 1.0;
  if (y > d0) {
    i1 = 0;
  } else {
    i1 = (int)y - 1;
  }

  b_emxInit_real_T(&b_y, 2);
  i2 = b_y->size[0] * b_y->size[1];
  b_y->size[0] = (int)NodesArray->data[0];
  b_y->size[1] = test_data->size[1];
  emxEnsureCapacity((emxArray__common *)b_y, i2, (int)sizeof(double));
  for (ar = 0; ar + 1 <= i0; ar++) {
    b_y->data[ar] = weight->data[ar];
  }

  emxInit_real_T(&C, 1);
  if ((b_y->size[1] == 1) || (temp->size[0] == 1)) {
    i0 = C->size[0];
    C->size[0] = b_y->size[0];
    emxEnsureCapacity((emxArray__common *)C, i0, (int)sizeof(double));
    ar = b_y->size[0];
    for (i0 = 0; i0 < ar; i0++) {
      C->data[i0] = 0.0;
      ib = b_y->size[1];
      for (i2 = 0; i2 < ib; i2++) {
        C->data[i0] += b_y->data[i0 + b_y->size[0] * i2] * temp->data[i2];
      }
    }
  } else {
    unnamed_idx_0 = (unsigned int)b_y->size[0];
    i0 = C->size[0];
    C->size[0] = (int)unnamed_idx_0;
    emxEnsureCapacity((emxArray__common *)C, i0, (int)sizeof(double));
    ar = (int)unnamed_idx_0;
    for (i0 = 0; i0 < ar; i0++) {
      C->data[i0] = 0.0;
    }

    if (b_y->size[0] == 0) {
    } else {
      ar = 0;
      while (ar <= 0) {
        i0 = b_y->size[0];
        for (ic = 1; ic <= i0; ic++) {
          C->data[ic - 1] = 0.0;
        }

        ar = b_y->size[0];
      }

      br = 0;
      ar = 0;
      while (ar <= 0) {
        ar = -1;
        i0 = br + b_y->size[1];
        for (ib = br; ib + 1 <= i0; ib++) {
          if (temp->data[ib] != 0.0) {
            ia = ar;
            i2 = b_y->size[0];
            for (ic = 0; ic + 1 <= i2; ic++) {
              ia++;
              C->data[ic] += temp->data[ib] * b_y->data[ia];
            }
          }

          ar += b_y->size[0];
        }

        br += b_y->size[1];
        ar = b_y->size[0];
      }
    }
  }

  emxInit_real_T(&b_C, 1);
  i0 = b_C->size[0];
  b_C->size[0] = C->size[0];
  emxEnsureCapacity((emxArray__common *)b_C, i0, (int)sizeof(double));
  ar = C->size[0];
  for (i0 = 0; i0 < ar; i0++) {
    b_C->data[i0] = C->data[i0] + weight->data[i1 + i0];
  }

  sigmoid(b_C, temp);
  cursor = (1.0 + (double)test_data->size[1] * NodesArray->data[0]) +
    NodesArray->data[0];
  i = 1;
  emxFree_real_T(&b_C);
  emxInit_real_T(&c_C, 1);
  while (i - 1 <= NodesArray->size[1] - 2) {
    y = (cursor + NodesArray->data[i - 1] * NodesArray->data[i]) - 1.0;
    if (cursor > y) {
      i0 = 1;
      i1 = 1;
    } else {
      i0 = (int)cursor;
      i1 = (int)y + 1;
    }

    y = cursor + NodesArray->data[i - 1] * NodesArray->data[i];
    d0 = ((cursor + NodesArray->data[i - 1] * NodesArray->data[i]) +
          NodesArray->data[i]) - 1.0;
    if (y > d0) {
      i2 = 0;
    } else {
      i2 = (int)y - 1;
    }

    ar = b_y->size[0] * b_y->size[1];
    b_y->size[0] = (int)NodesArray->data[i];
    b_y->size[1] = (int)NodesArray->data[i - 1];
    emxEnsureCapacity((emxArray__common *)b_y, ar, (int)sizeof(double));
    for (ar = -1; ar + 2 <= i1 - i0; ar++) {
      b_y->data[ar + 1] = weight->data[i0 + ar];
    }

    if ((b_y->size[1] == 1) || (temp->size[0] == 1)) {
      i0 = C->size[0];
      C->size[0] = b_y->size[0];
      emxEnsureCapacity((emxArray__common *)C, i0, (int)sizeof(double));
      ar = b_y->size[0];
      for (i0 = 0; i0 < ar; i0++) {
        C->data[i0] = 0.0;
        ib = b_y->size[1];
        for (i1 = 0; i1 < ib; i1++) {
          C->data[i0] += b_y->data[i0 + b_y->size[0] * i1] * temp->data[i1];
        }
      }
    } else {
      unnamed_idx_0 = (unsigned int)b_y->size[0];
      i0 = C->size[0];
      C->size[0] = (int)unnamed_idx_0;
      emxEnsureCapacity((emxArray__common *)C, i0, (int)sizeof(double));
      ar = (int)unnamed_idx_0;
      for (i0 = 0; i0 < ar; i0++) {
        C->data[i0] = 0.0;
      }

      if (b_y->size[0] == 0) {
      } else {
        ar = 0;
        while (ar <= 0) {
          i0 = b_y->size[0];
          for (ic = 1; ic <= i0; ic++) {
            C->data[ic - 1] = 0.0;
          }

          ar = b_y->size[0];
        }

        br = 0;
        ar = 0;
        while (ar <= 0) {
          ar = -1;
          i0 = br + b_y->size[1];
          for (ib = br; ib + 1 <= i0; ib++) {
            if (temp->data[ib] != 0.0) {
              ia = ar;
              i1 = b_y->size[0];
              for (ic = 0; ic + 1 <= i1; ic++) {
                ia++;
                C->data[ic] += temp->data[ib] * b_y->data[ia];
              }
            }

            ar += b_y->size[0];
          }

          br += b_y->size[1];
          ar = b_y->size[0];
        }
      }
    }

    i0 = c_C->size[0];
    c_C->size[0] = C->size[0];
    emxEnsureCapacity((emxArray__common *)c_C, i0, (int)sizeof(double));
    ar = C->size[0];
    for (i0 = 0; i0 < ar; i0++) {
      c_C->data[i0] = C->data[i0] + weight->data[i2 + i0];
    }

    sigmoid(c_C, temp);
    cursor += NodesArray->data[i - 1] * NodesArray->data[i];
    cursor += NodesArray->data[i];
    i++;
  }

  emxFree_real_T(&c_C);
  emxFree_real_T(&b_y);
  emxFree_real_T(&C);
  y = (cursor + NodesArray->data[NodesArray->size[1] - 1]) - 1.0;
  if (cursor > y) {
    i0 = 1;
    i1 = 1;
  } else {
    i0 = (int)cursor;
    i1 = (int)y + 1;
  }

  b_emxInit_real_T(&a, 2);
  i2 = a->size[0] * a->size[1];
  a->size[0] = 1;
  a->size[1] = i1 - i0;
  emxEnsureCapacity((emxArray__common *)a, i2, (int)sizeof(double));
  ar = i1 - i0;
  for (i2 = 0; i2 < ar; i2++) {
    a->data[a->size[0] * i2] = weight->data[(i0 + i2) - 1];
  }

  if ((i1 - i0 == 1) || (temp->size[0] == 1)) {
    y = 0.0;
    for (i0 = 0; i0 < a->size[1]; i0++) {
      y += a->data[a->size[0] * i0] * temp->data[i0];
    }
  } else {
    y = 0.0;
    for (i0 = 0; i0 < a->size[1]; i0++) {
      y += a->data[a->size[0] * i0] * temp->data[i0];
    }
  }

  emxFree_real_T(&a);
  emxFree_real_T(&temp);
  return 1.0 / (1.0 + exp(-(y + weight->data[weight->size[1] - 1])));
}

/* End of code generation (applyKerasTrainedModel.cpp) */
