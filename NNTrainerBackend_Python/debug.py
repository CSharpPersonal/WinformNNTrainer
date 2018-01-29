# gait study Neural Network main entry - Derek Liu 2017/12/08

from keras.models import Sequential
from keras.layers import Dense
from datetime import datetime
import numpy as np
import pandas
import os
import json
import scipy.io
np.random.seed(27)

# load config
path = os.path.dirname(os.path.abspath(__file__))
path_config = path+"\\testdata\\config.txt"
with open(path_config) as f:
    content = f.readlines()
content = [x.strip() for x in content]
num_layers = int(content[0][7:])
layer_neurons = np.zeros(num_layers,dtype=np.int)
for ind in range(0,num_layers):
    layer_neurons[ind] = int(content[ind+1][15:])
b_size = int(content[num_layers+1][11:])
optim = content[num_layers+2][11:]
loss = content[num_layers+3][10:]
print("config loaded: \n number of layers: %d\n batch size: %d\n" % (num_layers,b_size))
# load data
path_data = path+"\\testdata\\data.csv"
data = pandas.read_csv(path_data,delimiter=',', header=0)
data_set = data.values

X = data_set[:, 1:len(data_set[0,:])-1]
Y = data_set[:, 6]
print("data loaded, length = %d, proceed to define model" % (len(data_set[:, 0])))

# define model
model = Sequential()
num_input = len(X[0, :])
model.add(Dense(layer_neurons[0], input_dim=num_input, activation='sigmoid'))
for ind in range(0,num_layers-1):
    model.add(Dense(layer_neurons[ind+1], input_dim=layer_neurons[ind], activation='sigmoid'))
model.add(Dense(1, input_dim=layer_neurons[-1], activation='sigmoid'))
# compile model with adam (gradient descent)
model.compile(loss=loss, optimizer=optim, metrics=['mape'])

# fit model with input and output (below line for auto validation
history = model.fit(X, Y, epochs=1000, batch_size=b_size)

min_error = min(history.history['mean_absolute_percentage_error'])
# save model
save_dir = path + "\\testdata\\history\\"
directory = os.path.dirname(save_dir)
if not os.path.exists(directory):
    os.makedirs(directory)
# save architecture
model_file_name = save_dir + "model_" + optim + "_" + str(num_layers) + "_" + str(b_size) + "_" + \
                  datetime.now().strftime('%Y-%m-%d-%H-%M-%S') + ".json"
model_json = model.to_json()
with open(model_file_name, "w") as json_file:
    json_file.write(model_json)
# save weights
weights = model.get_weights()
weights_aslist = []
for numpy_weight_array in weights:
    weights_aslist.append(numpy_weight_array.tolist())
weights_json = json.dumps(weights_aslist)
weight_file_name = save_dir + "weight_" + optim + "_" + str(num_layers) + "_" + str(b_size) + "_" + \
                   datetime.now().strftime('%Y-%m-%d-%H-%M-%S') + ".json"
with open(weight_file_name, "w") as json_file:
    json.dump(weights_json,json_file)
print("train complete, minimal error: %.2f%%" % min_error)

# save for external use
scipy.io.savemat(
    'D:\\Derek\\Software\\temp\\WinformNNTrainer\\ApplyKerasModel_Matlab\\testdata\\model.mat',
    mdict={'net': weights})