%% load model and data
clear;
clc;
load('D:\Derek\Software\temp\WinformNNTrainer\OnlineNeuralNetworkTrainer\ApplyKerasModel\testdata\data.mat');

%% apply net
test_data = data(:,1:5);
test_results = zeros(size(test_data,1),size(test_data,2));
for i = 1:size(test_data,1)
    [test_results(i)] = applyKerasTrainedModel(test_data(i,:),weights,3,[10 10 10]);
end
expected_results = data(:,end);
figure;
plot(test_results,'bx'); hold on;
plot(expected_results,'r.');
ylim([0 3000]);
legend('test results','expected results');
grid on;