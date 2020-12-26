clear;clf;

%% Input and display the binary image
%N = 256;
x = imread('lenna.tif');
SIZE = size(x);
N=SIZE(1);
figure(1)
imshow(x)
x=rgb2gray(x);
%x=imresize(x,[N,N]);
x=double(x);
figure(2)
imshow(x,gray(256))

%% Blur the image, corrupt the image using WGN and display it
% h is the blurring filter, and sigma is the noise std
h = ones(4,4)/16;
%h=magic(4)/sum(magic(4));
sigma = 20;

Xf = fft2(x);
Hf = fft2(h,N,N);
y = real(ifft2(Hf.*Xf))+sigma*randn(N,N); % circular convolution %randn is normally distributed
%y = filter2(h,x)+sigma*randn(N,N);	  % linear convolution


figure(3)
imshow(y,gray(256))

% %% restoration using generalized inverse filtering
% gamma = 2;
% eix = inverseFilter(y,h,gamma);
% figure(3)
% imshow(eix)

%% restoration using generalized Wiener filtering
gamma = 1;
alpha = 1;
ewx = wienerFilter(y,h,sigma,gamma,alpha);
figure(4)
imshow(ewx,gray(256))

%PSNR = [psnr(y,x) psnr(eix,x) psnr(ewx,x)]
PSNR = abs([psnr(x,x) psnr(y,x) psnr(ewx,x)])
MSE = [immse(x,x) immse(y,x) immse(ewx,x)]
return
